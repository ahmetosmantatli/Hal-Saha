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
    public partial class frmSahaListesi : Form
    {
        public frmSahaListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");

        private void frmSahaListesi_Load(object sender, EventArgs e)
        {
            sahaOlustur();
            int sayi = SahaListePaneli.Controls.Count;
            if (sayi ==0)
            {
                lblMesaj.Text = "HİÇBİR SONUCA ULAŞILAMADI!!";
                lblMesaj.BackColor = Color.FromArgb(213,76,98);

            }
            else
            {
                lblMesaj.Text = "TOPLAM : " + sayi.ToString() + " ADET SONUC BULUNDU!";
                lblMesaj.BackColor = Color.FromArgb(43,178,123);
            }
        }
        void sahaOlustur()
        { //eger formda henuz kayıt yoksa 0 ise bu yonlendırme ekranına ıhtıyac duyulmamalı bunun kontrolunu de yapıcaz!

            SahaListePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar order by ad asc ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sahalar sablon = new sahalar();
                sablon.lblSahaAdi.Text = oku["ad"].ToString();
                sablon.lblSahaNumarasi.Text = oku["kod"].ToString();
                SahaListePaneli.Controls.Add(sablon);
            }
            baglanti.Close();
        }

        

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SahaListePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar WHERE ad LIKE '%" +txtSearch.Text+ "%' collate Latin1_General_CI_AI order by ad asc ", baglanti);
            //alandan gelen kısmı like komutu ile aratmıs oluyoruz! birden fazla sonuc olursa order by ile sıralarız //latin ile turkce harf taratırken bulamama sorununu cozduk!
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                sahalar sablon = new sahalar();
                sablon.lblSahaAdi.Text = oku["ad"].ToString();
                sablon.lblSahaNumarasi.Text = oku["kod"].ToString();
                SahaListePaneli.Controls.Add(sablon);
            }
            baglanti.Close();
            int sayi = SahaListePaneli.Controls.Count;
            if (sayi == 0)
            {
                lblMesaj.Text = "HİÇBİR SONUCA ULAŞILAMADI!!";
                lblMesaj.BackColor = Color.FromArgb(213, 76, 98);

            }
            else
            {
                lblMesaj.Text = "TOPLAM : " + sayi.ToString() + " ADET SONUC BULUNDU!";
                lblMesaj.BackColor = Color.FromArgb(43, 178, 123);
            }
        }

        private void frmSahaListesi_Activated(object sender, EventArgs e)
        {
            //saha liste ekranından saha sılersek o an sılınmıs olması lazım bunun ıcınde o ankı konumda database okuncak yanı saha olustur ıcındekı komutlar !!
           /* sahaOlustur();
            int sayi = SahaListePaneli.Controls.Count;
            if (sayi == 0)
            {
                lblMesaj.Text = "HİÇBİR SONUCA ULAŞILAMADI!!";
                lblMesaj.BackColor = Color.FromArgb(213, 76, 98);

            }
            else
            {
                lblMesaj.Text = "TOPLAM : " + sayi.ToString() + " ADET SONUC BULUNDU!";
                lblMesaj.BackColor = Color.FromArgb(43, 178, 123);
            } */
        }

        private void SahaListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
