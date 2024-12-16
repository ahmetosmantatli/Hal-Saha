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
    public partial class frmSahaBilgiDuzenlemeEkrani : Form
    {
        public frmSahaBilgiDuzenlemeEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");

        public string gelenKod = "";

        private void rBDogal_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "1";
            rBDogal.ForeColor = Color.FromArgb(229,125,0);
            rBYapay.ForeColor = Color.FromArgb(64, 64, 64);

        }

        private void rBAcik_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "1";
            rBAcik.ForeColor = Color.FromArgb(229, 125, 0);
            rBKapali.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBStandart_CheckedChanged(object sender, EventArgs e)
        {
            lblEn.Text = "200";
            lblBoy.Text = "500";
            rBDiger.ForeColor = Color.FromArgb(229, 125, 0);
            rBKapali.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = false;
            gBoy.Visible = false;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void rBYapay_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "2";
            rBYapay.ForeColor = Color.FromArgb(229, 125, 0);
            rBDogal.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBKapali_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "2";
            rBKapali.ForeColor = Color.FromArgb(229, 125, 0);
            rBAcik.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBDiger_CheckedChanged(object sender, EventArgs e)
        {
            lblEn.Text = "800";
            lblBoy.Text = "400";

            rBDiger.ForeColor = Color.FromArgb(229, 125, 0);
            rBStandart.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = true;
            gBoy.Visible = true;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rBDiger.Checked)
            {

                if (txtEn.Text != "" && txtBoy.Text != "")
                {
                    //degerler girilmistir || İSLEMLER YAPILABILIR
                    //MessageBox.Show("SECİLİ VE DOLU");
                    guncelle();


                }
                else
                {//degerleri giriniz    
                 //MessageBox.Show("SECİLİ VE BOS");
                    popupMenu menu = new popupMenu();
                    menu.lblMesaj.BackColor = Color.FromArgb(64,64,64);
                    menu.lblMesaj.Text = "LUTFEN SAHAYA AIT EN VE BOY DEGERLERINI GIRINIZ!";
                    menu.Show();
                }
            }
            else
            {
                guncelle();
            }
            
        }

        void guncelle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Tbl_Sahalar SET ad = @ad, cim =@cim, tur = @tur, boyut = @boyut , en = @en , boy = @boy , aciklama = @aciklama where  kod= @kod", baglanti);
            komut.Parameters.AddWithValue("@kod", gelenKod);
            komut.Parameters.AddWithValue("@ad", txtSahaAdi.Text.ToUpper());
            komut.Parameters.AddWithValue("@cim", lblCimTuru.Text);
            komut.Parameters.AddWithValue("@tur", lblSahaTuru.Text);
            if (rBStandart.Checked) //true anlamında
            {
                komut.Parameters.AddWithValue("@boyut", "1");
                komut.Parameters.AddWithValue("@en", "200");
                komut.Parameters.AddWithValue("@boy", "500");
            }
            else
            {
                komut.Parameters.AddWithValue("@boyut", "2");
                komut.Parameters.AddWithValue("@en", txtEn.Text);
                komut.Parameters.AddWithValue("@boy", txtBoy.Text);
            }
            komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text.ToUpper());
            komut.ExecuteNonQuery();
            baglanti.Close();

            bilgiGetir();
            popupMenu menu = new popupMenu();
            menu.lblMesaj.BackColor = Color.FromArgb(43, 178, 123);
            menu.lblMesaj.Text = "SAHA KAYIT ISLEMI BASARILI SEKILDE GUNCELLENMISTIR!";
            menu.Show();
        }
        void bilgiGetir()
        {
            //db den verılerı alıcaz guncelleme yapıcagımızdan saha ısmı ve acıklamadakı verılerıde dbden almalıyız
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar where kod=@kod",baglanti);
            komut.Parameters.AddWithValue("kod" , gelenKod);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                txtSahaAdi.Text = oku["ad"].ToString();
                txtAciklama.Text = oku["aciklama"].ToString();

                if (oku["cim"].ToString() == "1")
                {
                    rBDogal.Checked = true;
                }
                else
                {
                    rBYapay.Checked = true;
                }
                if (oku["tur"].ToString() == "1")
                {
                    rBAcik.Checked = true;
                }
                else
                {
                    rBKapali.Checked = true;
                }
                if (oku["boyut"].ToString() == "1")
                {
                    rBStandart.Checked = true;

                }
                else
                {
                    rBDiger.Checked = true; //saha kayıt ekr duzenlede rbdıger adlı ısmlendırme yerıne radıobuton1 olabılır onu not ettım karısmasın dıye
                    txtEn.Text = oku["en"].ToString();
                    txtBoy.Text = oku["boy"].ToString();
                }
            }
            else
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(213,76,98);
                menu.lblMesaj.Text = "SAHA KAYDINA ULASIM SAGLANAMADI!";
                menu.ShowDialog();
                this.Close();
            }
            baglanti.Close();
        }

        private void frmSahaBilgiDuzenlemeEkrani_Load(object sender, EventArgs e)
        {
            bilgiGetir();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(229, 125, 0);
            button2.BackColor = Color.FromArgb(64, 64, 64);
            Btn_Kapat.ForeColor = Color.White;
            Btn_Kapat.BackColor = Color.FromArgb(229,125,0);   
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            

            button2.BackColor = Color.FromArgb(229, 125, 0);
            button2.ForeColor = Color.White;
            Btn_Kapat.ForeColor = Color.White;
            Btn_Kapat.BackColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_Click(object sender, EventArgs e)
        { //kaydı siliyoruz
            //direkt sileriz yada dialog result ile menu olusturup sileriz!
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Sahalar where kod = @kod",baglanti);
            komut.Parameters.AddWithValue("@kod",gelenKod);
            komut.ExecuteNonQuery();

            baglanti.Close();

            
            popupMenu menu = new popupMenu();
            menu.lblMesaj.BackColor = Color.FromArgb(43,178,123);
            menu.lblMesaj.Text = "SAHA KAYIT BİLGİLERİ BASARILI SEKİLDE SİLİNMİSTİR!";
            menu.ShowDialog();
            this.Close();
        }
    }
}
