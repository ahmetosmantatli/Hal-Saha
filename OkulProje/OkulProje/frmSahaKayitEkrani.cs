using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Data.SqlClient;

namespace OkulProje
{
    public partial class frmSahaKayitEkrani : Form
    {
        public frmSahaKayitEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");
        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblEn.Text = "800";
            lblBoy.Text = "400";

            rBDiger.ForeColor = Color.MediumPurple;
            rBStandart.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = true;
            gBoy.Visible = true;
            txtBoy.Text = "";
            txtEn.Text = "";
        }//ignore diger olan

        private void label3_Click(object sender, EventArgs e)
        {

        }//ignore

        private void rBDogal_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "1";
            rBDogal.ForeColor = Color.MediumPurple;
            rBYapay.ForeColor = Color.FromArgb(64,64,64);
        }

        private void rBYapay_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "2";
            rBYapay.ForeColor = Color.MediumPurple;
            rBDogal.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBAcik_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "1";
            rBAcik.ForeColor = Color.MediumPurple;
            rBKapali.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBKapali_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "2";
            rBKapali.ForeColor = Color.MediumPurple;
            rBAcik.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBStandart_CheckedChanged(object sender, EventArgs e)
        {
            lblEn.Text = "200";
            lblBoy.Text = "500";
            rBDiger.ForeColor = Color.MediumPurple;
            rBKapali.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = false;
            gBoy.Visible = false;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void frmSahaKayitEkrani_Load(object sender, EventArgs e)
        {
            sahaKoduOlustur();
        }
        //id kod    
        void sahaKoduOlustur()
        {
            Random random = new Random();
            string semboller = "01234567890987654321098756732112"; //nekadar cok verı okadar benzersız olusum
            string olusanKod = "";
            for (int i = 1; i < 6; i++)
            {
                olusanKod += semboller[random.Next(semboller.Length)];
            }
            lblSahaKod.Text=olusanKod.ToString();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (txtSahaAdi.Text!="")
            {
                
                if (rBDiger.Checked==true)
                {
                    if (txtEn.Text!="" && txtBoy.Text!="")
                    {
                        //degerler girilmistir || İSLEMLER YAPILABILIR
                        //MessageBox.Show("SECİLİ VE DOLU");
                        kaydet();


                    }
                    else
                    {//degerleri giriniz    
                     //MessageBox.Show("SECİLİ VE BOS");
                        popupMenu menu = new popupMenu();
                        menu.lblMesaj.BackColor = Color.FromArgb(229, 125, 0);
                        menu.lblMesaj.Text = "LUTFEN SAHAYA AIT EN VE BOY DEGERLERINI GIRINIZ!";
                        menu.Show();
                    }
                }
                else
                {
                    kaydet();
                }
            }
            else
            {
                //MessageBox.Show("İSİM BOS GECİLEMEZ");
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(229,125,0);
                menu.lblMesaj.Text = "SAHA ISIM ALANI BOS GECILEMEZ!";
                menu.Show();
            }
        }
        void kaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Sahalar (kod,ad,cim,tur,boyut,en,boy,aciklama) values (@kod,@ad,@cim,@tur,@boyut,@en,@boy,@aciklama)", baglanti);
            komut.Parameters.AddWithValue("@kod",lblSahaKod.Text);
            komut.Parameters.AddWithValue("@ad",txtSahaAdi.Text.ToUpper());
            komut.Parameters.AddWithValue("@cim",lblCimTuru.Text);
            komut.Parameters.AddWithValue("@tur",lblSahaTuru.Text);
            if (rBStandart.Checked) //true anlamında
            {
                komut.Parameters.AddWithValue("@boyut","1");
                komut.Parameters.AddWithValue("@en","200");
                komut.Parameters.AddWithValue("@boy","500");
            }
            else
            {
                komut.Parameters.AddWithValue("@boyut","2");
                komut.Parameters.AddWithValue("@en",txtEn.Text);
                komut.Parameters.AddWithValue("@boy",txtBoy.Text);
            }
            komut.Parameters.AddWithValue("@aciklama",txtAciklama.Text.ToUpper());
            komut.ExecuteNonQuery();
            baglanti.Close();
            temizlemeMetodu();
            sahaKoduOlustur(); //kayıt edılen kodun tekrarı olmaması gereken durum
            popupMenu menu = new popupMenu();
            menu.lblMesaj.BackColor = Color.FromArgb(43,178,123);
            menu.lblMesaj.Text = "SAHA KAYIT ISLEMI BASARILI SEKILDE GERCEKLESTIRILDI";
            menu.Show();

        }
        void temizlemeMetodu()
        {
            txtSahaAdi.Text = "";
            txtAciklama.Text = "";
            txtEn.Text = "";
            txtBoy.Text = "";

            gBEn.Visible = false;
            gBoy.Visible = false;
            rBAcik.Checked = true;
            rBDogal.Checked = true;
            rBStandart.Checked = true;
            txtSahaAdi.Focus();
        }

    }
}
