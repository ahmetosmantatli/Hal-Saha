using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OkulProje
{
    public partial class frmSahaYonlendirmEkrani : Form
    {
        public frmSahaYonlendirmEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSahaYonlendirmEkrani_Load(object sender, EventArgs e)
        {
            bilgiGetir();
            int sayi = SahaListePaneli.Controls.Count;
            if (sayi ==0)
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(213,76,98);
                menu.lblMesaj.Text = "HERHANGI BIR KAYDA ULASIM SAGLANAMADI!";
                menu.ShowDialog();
                this.Close();
            }
        }
        void bilgiGetir() { //eger formda henuz kayıt yoksa 0 ise bu yonlendırme ekranına ıhtıyac duyulmamalı bunun kontrolunu de yapıcaz!

            SahaListePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar order by ad asc ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Button btn = new Button();
                btn.Text = oku["ad"].ToString();
                btn.Tag = oku["kod"].ToString();
                btn.Width = 170;
                btn.Height = 80;
                btn.BackColor = Color.MediumPurple;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Cursor = Cursors.Hand;

                btn.MouseMove += btn_MouseMove;
                btn.MouseLeave += btn_MouseLeave;
                btn.Click += btn_Click;

                SahaListePaneli.Controls.Add(btn);
            }
            baglanti.Close();


        }

        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            frmSahaBilgiDuzenlemeEkrani frm = new frmSahaBilgiDuzenlemeEkrani();
            frm.gelenKod = btn.Tag.ToString();
            frm.ShowDialog();

            MessageBox.Show(btn.Tag.ToString());
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.MediumPurple;
        }

        private void btn_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void frmSahaYonlendirmEkrani_Activated(object sender, EventArgs e)
        {
            bilgiGetir();
        }

        private void SahaListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
