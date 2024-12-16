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
    public partial class frmAnaEkran : Form
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.file;
            button1.ForeColor = Color.MediumPurple;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.file;
            button1.ForeColor = Color.FromArgb(64,64,64);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.file__2_;
            button2.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.file__2_;
            button2.ForeColor = Color.MediumPurple;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.ball;
            button3.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Image = Properties.Resources.ball;
            button3.ForeColor = Color.MediumPurple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSecimEkrani frm = new frmSecimEkrani();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSahaListesi frm = new frmSahaListesi();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKarsilasmaEkrani frm = new frmKarsilasmaEkrani();
            frm.ShowDialog();
        }

        private void frmAnaEkran_Load(object sender, EventArgs e)
        {
            //labellara gun ismi atama
            gun1.Text = DateTime.Today.ToShortDateString() + "\n" + DateTime.Today.ToString("dddd");
            gun2.Text = DateTime.Today.AddDays(1).ToShortDateString() + "\n" + DateTime.Today.AddDays(1).ToString("dddd");
            gun3.Text = DateTime.Today.AddDays(2).ToShortDateString() + "\n" + DateTime.Today.AddDays(2).ToString("dddd");
            gun4.Text = DateTime.Today.AddDays(3).ToShortDateString() + "\n" + DateTime.Today.AddDays(3).ToString("dddd");
            gun5.Text = DateTime.Today.AddDays(4).ToShortDateString() + "\n" + DateTime.Today.AddDays(4).ToString("dddd");
            gun6.Text = DateTime.Today.AddDays(5).ToShortDateString() + "\n" + DateTime.Today.AddDays(5).ToString("dddd");
            gun7.Text = DateTime.Today.AddDays(6).ToShortDateString() + "\n" + DateTime.Today.AddDays(6).ToString("dddd");

            birincilPanel.Controls.Clear();
            //dongü ile 14 adet user control
            for (int i =10; i<24; i++)
            {
                //10.00- 11.00
                SahaKontrol sablon = new SahaKontrol();
                sablon.lblSaat.Text = i.ToString() + ":00 - " + (i+1).ToString() + ":00";
                sablon.lblTarih.Text = DateTime.Today.ToShortDateString();
                birincilPanel.Controls.Add(sablon);

            }

            ikinciPanel.Controls.Clear();
            //ikincigün
            for (int i = 10; i < 24; i++)
            {
                //10.00- 11.00
                SahaKontrol sablon = new SahaKontrol();
                sablon.lblSaat.Text = i.ToString() + ":00 - " + (i + 1).ToString() + ":00";
                sablon.lblTarih.Text = DateTime.Today.AddDays(1).ToShortDateString();
                ikinciPanel.Controls.Add(sablon);

            }

            ucuncuPanel.Controls.Clear();
            //ücüncügün
            for (int i = 10; i < 24; i++)
            {
                //10.00- 11.00
                SahaKontrol sablon = new SahaKontrol();
                sablon.lblSaat.Text = i.ToString() + ":00 - " + (i + 1).ToString() + ":00";
                sablon.lblTarih.Text = DateTime.Today.AddDays(2).ToShortDateString();
                ucuncuPanel.Controls.Add(sablon);

            }
            dorduncuPanel.Controls.Clear();
            //dordungugün
            for (int i = 10; i < 24; i++)
            {
                //10.00- 11.00
                SahaKontrol sablon = new SahaKontrol();
                sablon.lblSaat.Text = i.ToString() + ":00 - " + (i + 1).ToString() + ":00";
                sablon.lblTarih.Text = DateTime.Today.AddDays(3).ToShortDateString();
                dorduncuPanel.Controls.Add(sablon);

            }
            besinciPanel.Controls.Clear();
            //besincigün
            for (int i = 10; i < 24; i++)
            {
                //10.00- 11.00
                SahaKontrol sablon = new SahaKontrol();
                sablon.lblSaat.Text = i.ToString() + ":00 - " + (i + 1).ToString() + ":00";
                sablon.lblTarih.Text = DateTime.Today.AddDays(4).ToShortDateString();
                besinciPanel.Controls.Add(sablon);

            }
            altinciPanel.Controls.Clear();
            //altincigün
            for (int i = 10; i < 24; i++)
            {
                //10.00- 11.00
                SahaKontrol sablon = new SahaKontrol();
                sablon.lblSaat.Text = i.ToString() + ":00 - " + (i + 1).ToString() + ":00";
                sablon.lblTarih.Text = DateTime.Today.AddDays(5).ToShortDateString();
                altinciPanel.Controls.Add(sablon);

            }
            yedinciPanel.Controls.Clear();
            //yedincigün
            for (int i = 10; i < 24; i++)
            {
                //10.00- 11.00
                SahaKontrol sablon = new SahaKontrol();
                sablon.lblSaat.Text = i.ToString() + ":00 - " + (i + 1).ToString() + ":00";
                sablon.lblTarih.Text = DateTime.Today.AddDays(6).ToShortDateString();
                yedinciPanel.Controls.Add(sablon);

            }
        }
    }
}
