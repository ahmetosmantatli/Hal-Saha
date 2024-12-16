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
    public partial class frmKarsilasmaEkrani : Form
    {
        public frmKarsilasmaEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");
        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKarsilasmaEkrani_Load(object sender, EventArgs e)
        {
            lblSecilenTarih.Text = "null";
            lblSecilenSaat.Text = "null";
            lblSecilenSaha.Text = "12345"; //dbde char(5) atamalı kaydı var bu hatayı manıpule etmek ıcın bu sekılde kaydettık

            DateTime bugun = DateTime.Now;
            button1.Text = bugun.ToShortDateString(); //x time
            button2.Text = bugun.AddDays(1).ToShortDateString(); //burayı forla donemedım hep ekleme yapcagım nesneler degısıyor
            button3.Text = bugun.AddDays(2).ToShortDateString();
            button4.Text = bugun.AddDays(3).ToShortDateString();
            button5.Text = bugun.AddDays(4).ToShortDateString();
            button6.Text = bugun.AddDays(5).ToShortDateString();
            button7.Text = bugun.AddDays(6).ToShortDateString();
            //sahalisteyap buraya alınır mı ?

        }

        void SahaListeYap()
        { //eger formda henuz kayıt yoksa 0 ise bu yonlendırme ekranına ıhtıyac duyulmamalı bunun kontrolunu de yapıcaz!
            //kontrol et ıf mı whıle mı dıye 15.12 sonuc : while
            SahaListePaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar order by ad asc ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Button btn = new Button();
                btn.Text = oku["ad"].ToString();
                btn.Tag = oku["kod"].ToString();
                btn.Width = 100;
                btn.Height = 40;
                btn.BackColor = Color.FromArgb(64,64,64); ; //**renklendırmeye goz atabılırız
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Cursor = Cursors.Hand;

                //btn.MouseMove += btn_MouseMove;
                //btn.MouseLeave += btn_MouseLeave;
                btn.Click += btn_Click;

                SahaListePaneli.Controls.Add(btn);
            }
            baglanti.Close();

            //saha kontrol!
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select * from Tbl_Kayitlar where tarih = @tarih AND saat = @saat ", baglanti);
            komut2.Parameters.AddWithValue("@tarih",lblSecilenTarih.Text.Trim());
            komut2.Parameters.AddWithValue("@saat", lblSecilenSaat.Text.Trim());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read()) {

                foreach (var control in SahaListePaneli.Controls)
                { 
                    if (control is Button button) // Sadece Button türündeki kontrollerle çalış
                    {
                        if (button.Tag.ToString() == oku2["saha"].ToString())
                        {
                            if (oku2["islem"].ToString() =="1")
                            {
                                button.BackColor = Color.Red; //dolu anlamı tasıyacak
                            }
                            else if (oku2["islem"].ToString() == "2")
                            {
                                button.BackColor = Color.Orange; //rezerve anlamı tasıyacak
                            }
                        }
                    }
                }

            }
            baglanti.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblSecilenSaha.Text = btn.Tag.ToString(); //text degil tag alıyoruz tag = kod // text = ad

            foreach (var control in SahaListePaneli.Controls)
            {
                if (control is Button button) 
                {
                    if (lblSecilenSaha.Text == btn.Tag.ToString()) 
                    {
                       
                        button.BackColor = Color.FromArgb(64,64,64);
                       //o an secim yapıcagımız buton rengını belırlıyoruz fonksıyon amacı secim yaptırmak click ile 
                        btn.BackColor = Color.Blue;

                    }//eger secili olmayan durumu ıcın else yazarsam ve butonu eskı renge dondurmek ıstersem ordakı else calısmıycak!!
                }
            }
            //saha kontrol!
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("select * from Tbl_Kayitlar where tarih = @tarih AND saat = @saat ", baglanti);
            komut2.Parameters.AddWithValue("@tarih", lblSecilenTarih.Text.Trim());
            komut2.Parameters.AddWithValue("@saat", lblSecilenSaat.Text.Trim());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {

                foreach (var control in SahaListePaneli.Controls)
                {
                    if (control is Button button) // Sadece Button türündeki kontrollerle çalış
                    {
                        if (button.Tag.ToString() == oku2["saha"].ToString())
                        {
                            if (oku2["islem"].ToString() == "1")
                            {
                                button.BackColor = Color.Red; //dolu anlamı tasıyacak
                            }
                            else
                            {
                                button.BackColor = Color.Orange; //rezerve anlamı tasıyacak
                            }
                        }
                    }
                }

            }
            baglanti.Close();

            //DAHA ONCE SECILMIS SAHALARDA ISLEM OLMAMALI

            if (btn.BackColor==Color.Red || btn.BackColor==Color.Orange )
            {
                lblSecilenSaha.Text = "null"; //secılen saha boyalı zaten onusecmeyı denerse saha numarasını mutela sıstem otomayık doldurulmadı kabul etsin!!
            }
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            string sonTarih = button7.Text;
            DateTime olustur = Convert.ToDateTime(sonTarih);
            button1.Text = olustur.AddDays(1).ToShortDateString(); //x time
            button2.Text = olustur.AddDays(2).ToShortDateString(); 
            button3.Text = olustur.AddDays(3).ToShortDateString();
            button4.Text = olustur.AddDays(4).ToShortDateString();
            button5.Text = olustur.AddDays(5).ToShortDateString();
            button6.Text = olustur.AddDays(6).ToShortDateString();
            button7.Text = olustur.AddDays(7).ToShortDateString();

            foreach (var control in GBTarih.Controls)
                //kontrol var ile baslatıldı ve ıcınde kosulla buton olanlardan veri alıncak hale getirildi
                //cunku sıstem hata atar groupboxun ıcınde textbox var bunun ıcınde butonvar sadece buton olanları dondurmek ıcın bu sekılde ılerledık 
            {
                if (control is Button item) // Sadece Button türündeki kontrollerle çalış
                {
                    if (DateTime.TryParse(item.Text, out DateTime buttonDate))
                    {
                        TimeSpan ts = buttonDate - DateTime.Today;

                        if (ts.Days < 0)
                        {
                            // Geçmişteki tarihleri kırmızıya boyuyoruz
                            item.BackColor = Color.FromArgb(213, 76, 98);
                        }
                        else
                        {
                            // Gelecekteki tarihleri yeşile boyuyoruz
                            item.BackColor = Color.FromArgb(43, 178, 123);
                        }
                    }
                    else
                    {
                        // Geçersiz bir tarih varsa griye boyuyoruz
                        item.BackColor = Color.Gray;
                    }
                }
            }
            foreach (var control in GBTarih.Controls)
            {//sectigimiz tarih isaretli olarak kalsın degismedigi surece ozaman renklerle oynarsın!!
                if (control is Button button) // Sadece Button türündeki kontrollerle çalış
                {
                    if (button.Text == lblSecilenTarih.Text)
                    {
                        button.BackColor = Color.FromArgb(64, 64, 64);
                    }
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            string ilkTarih = button7.Text;
            DateTime olustur = Convert.ToDateTime(ilkTarih);
            button1.Text = olustur.AddDays(-7).ToShortDateString(); //x time
            button2.Text = olustur.AddDays(-6).ToShortDateString();
            button3.Text = olustur.AddDays(-5).ToShortDateString();
            button4.Text = olustur.AddDays(-4).ToShortDateString();
            button5.Text = olustur.AddDays(-3).ToShortDateString();
            button6.Text = olustur.AddDays(-2).ToShortDateString();
            button7.Text = olustur.AddDays(-1).ToShortDateString();


            foreach (var control in GBTarih.Controls)
            {
                if (control is Button item) // Sadece Button türündeki kontrollerle çalış
                {
                    if (DateTime.TryParse(item.Text, out DateTime buttonDate))
                    {
                        TimeSpan ts = buttonDate - DateTime.Today;

                        if (ts.Days < 0)
                        {
                            // Geçmişteki tarihleri kırmızıya boyuyoruz
                            item.BackColor = Color.FromArgb(213, 76, 98);
                        }
                        else
                        {
                            // Gelecekteki tarihleri yeşile boyuyoruz
                            item.BackColor = Color.FromArgb(43, 178, 123);
                        }
                    }
                    else
                    {
                        // Geçersiz bir tarih varsa griye boyuyoruz
                        item.BackColor = Color.Gray;
                    }
                }
            }
            foreach (var control in GBTarih.Controls)
            {//sectigimiz tarih isaretli olarak kalsın degismedigi surece ozaman renklerle oynarsın!!
                if (control is Button button) // Sadece Button türündeki kontrollerle çalış
                {
                    if (button.Text == lblSecilenTarih.Text)
                    {
                        button.BackColor = Color.FromArgb(64,64,64);                                                                      
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*btn click attıgında onun gununu ustte yan tarafa yazıyor
             bu yazımın aynısını gbtarih text box ısmıdır burda buton dısında nesne olarak algılayabılır
            textboxu bu yuzden bazen calısıyor bazen calısmıyor durumu olabılır suphelı yaklasım bunu fonks
            icinde yazmam gerekliydi */

            Button btn  = (Button)sender;
            DateTime tarih = Convert.ToDateTime(btn.Text);
            GBTarih.Text = tarih.ToShortDateString() + " - " + tarih.ToString("ddd");

            lblSecilenTarih.Text = tarih.ToShortDateString();

            if (btn.BackColor == Color.FromArgb(43,178,123))
            {
                foreach (var control in GBTarih.Controls)
                {
                    if (control is Button button) // Sadece Button türündeki kontrollerle çalış
                    {
                        if (lblSecilenTarih.Text == btn.Text)
                        {
                            button.BackColor = Color.FromArgb(43, 178, 123); //button fonk ıcınde tanımlı olan buttona gecerlı yanı hepsını ele alır
                                                                           //alttakı btn ıse bır ustte tanıdıgım btn dır buna teker teker renk atma aksıyonu ıcın kullanıcam manıpule olunmamalı !!
                            /* bu sayede saate tıklayıp secım yapıldıgında tek secım yapılmıs olcak her yenı secım ıcın kendını tekrar döndü!!*/
                            btn.BackColor = Color.FromArgb(64,64,64);
                        }

                    }
                }
            }
            if (lblSecilenTarih.Text!="null" && lblSecilenSaat.Text!="null")
            {
                SahaListeYap(); //saha listesi getirme kosulu !!
            }
           
        }

        private void SaatClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GBSaat.Text = btn.Text;
            lblSecilenSaat.Text = btn.Text;
            foreach (var control in GBSaat.Controls)
            {
                if (control is Button button) // Sadece Button türündeki kontrollerle çalış
                {
                    if (GBSaat.Text == btn.Text) 
                    {
                        button.BackColor = Color.FromArgb(64,64,64); //button fonk ıcınde tanımlı olan buttona gecerlı yanı hepsını ele alır
                        //alttakı btn ıse bır ustte tanıdıgım btn dır buna teker teker renk atma aksıyonu ıcın kullanıcam manıpule olunmamalı !!
                        /* bu sayede saate tıklayıp secım yapıldıgında tek secım yapılmıs olcak her yenı secım ıcın kendını tekrar döndü!!*/
                        btn.BackColor = Color.OrangeRed; 
                    }
                   
                }
            }
            if (lblSecilenTarih.Text != "null" && lblSecilenSaat.Text != "null")
            {
                SahaListeYap(); //saha listesi getirme kosulu !!
            }
        }

        private void rBErkek_CheckedChanged(object sender, EventArgs e)
        {
            lblSecilenCinsiyet.Text = "1";          
            rBErkek.ForeColor = Color.MediumPurple;
            rBKadın.ForeColor = Color.FromArgb(64,64,64);
        }

        private void rBKadın_CheckedChanged(object sender, EventArgs e)
        {
            lblSecilenCinsiyet.Text = "2";
            rBKadın.ForeColor = Color.MediumPurple;
            rBErkek.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //input kontrolu - araç kontrolü

            if (txtTC.Text!="" && txtAd.Text!="" && txtTel.Text!="" && lblSecilenTarih.Text!="null" && lblSecilenSaat.Text!="null" && lblSecilenSaha.Text!="null")
            {
                //alanlar doludur
                //soyutlamaya gore benzer verılerı dızı yapısına alıp burayı forla dondurugum bı sıstem yazıp kolayca temız kullanım yapmak ısterdım ama wındowfs form yapılarında bunu yapamadım
                lblTcKimlik.Text = txtTC.Text;
                lblAdSoyad.Text = txtAd.Text;
                lblMail.Text = txtMail.Text;
                lblTelNo.Text = txtTel.Text;
                lblAciklama.Text = txtAciklama.Text;

                bilgiPaneli.Visible = false;
                PnlOdemEkrani.Visible = true; //bır panelı kapayıp dıger panele yonlendırıcez odeme ekranına!
                label1.Text = "[KİRALAMA TÜRÜ VE ÖDEME]";
                Btn_Kapat.BackColor = Color.Orange;
                PnlLogo.BackColor = Color.Orange;

            }
            else
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(229, 125, 0);
                menu.lblMesaj.Text = "LUTFEN GEREKEN ALANLARI DOLDURUNUZ!";
                menu.Show();
            }

            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        { //ignore

        }

        private void button24_Click(object sender, EventArgs e)
        {
            bilgiPaneli.Visible=true;
            PnlOdemEkrani.Visible = false;
            label1.Text = "[SAHA KİRALAMA EKRANI]";
            Btn_Kapat.BackColor = Color.MediumPurple;
            PnlLogo.BackColor = Color.MediumPurple;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (txtFiyat.Text!="")
            {
                lblFiyat.Text = txtFiyat.Text;
                bilgiPaneli.Visible = false;
                PnlOdemEkrani.Visible = false;
                panel2.Visible = true;
                label1.Text = "[İŞLEM TAMAMLAMA EKRANI]";
                Btn_Kapat.BackColor = Color.MediumPurple;
                PnlLogo.BackColor = Color.MediumPurple;
            }
            else
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(229, 125, 0);
                menu.lblMesaj.Text = "TOPLAM FIYAT BILGISI GIRINIZ!!";
                menu.Show();
            }
        }

        private void kirala_CheckedChanged(object sender, EventArgs e)
        {
            lblislemTuru.Text = "KİRALAMA";
            kirala.ForeColor = Color.Orange;
            rezerveet.ForeColor = Color.FromArgb(64,64,64);
        }

        private void rezerveet_CheckedChanged(object sender, EventArgs e)
        {
            lblislemTuru.Text = "REZERVE";
            rezerveet.ForeColor = Color.Orange;
            kirala.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            lblOdemeDurumu.Text = "ÖDENDİ";
            odendi.ForeColor = Color.Orange;
            odenmedi.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            lblOdemeDurumu.Text = "ÖDENMEDİ";
            odenmedi.ForeColor = Color.Orange;
            odendi.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void nakit_CheckedChanged(object sender, EventArgs e)
        {
            lblOdemeTuru.Text = "NAKİT";
            nakit.ForeColor = Color.Orange;
            kart.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void kart_CheckedChanged(object sender, EventArgs e)
        {
            lblOdemeTuru.Text = "KART";
            kart.ForeColor = Color.Orange;
            nakit.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //GERİ DÖN
            bilgiPaneli.Visible = false;
            PnlOdemEkrani.Visible = true;
            panel2.Visible = false;
            label1.Text = "[KİRALAMA TÜRÜ VE ÖDEME]";
            Btn_Kapat.BackColor = Color.MediumPurple;
            PnlLogo.BackColor = Color.MediumPurple;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            //TAMAMLA database kayıt!!
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Kayitlar (tc,adsoyad,tel,mail,cinsiyet,aciklama,tarih,saat,saha,islem,durum,tur,fiyat,kayitTarihi) values (@tc,@adsoyad,@tel,@mail,@cinsiyet,@aciklama,@tarih,@saat,@saha,@islem,@durum,@tur,@fiyat,@kayitTarihi)", baglanti);
            komut.Parameters.AddWithValue("@tc",lblTcKimlik.Text);
            komut.Parameters.AddWithValue("@adsoyad", lblAdSoyad.Text);
            komut.Parameters.AddWithValue("@tel", lblTelNo.Text);
            komut.Parameters.AddWithValue("@mail", lblMail.Text);
            //cinsiyet
            if (lblSecilenCinsiyet.Text =="ERKEK")
            {
                komut.Parameters.AddWithValue("@cinsiyet","1");
            }
            else
            {
                komut.Parameters.AddWithValue("@cinsiyet", "2");
            }
           
            komut.Parameters.AddWithValue("@aciklama", lblAciklama.Text);
            komut.Parameters.AddWithValue("@tarih", lblSecilenTarih.Text);
            komut.Parameters.AddWithValue("@saat", lblSecilenSaat.Text);
            komut.Parameters.AddWithValue("@saha", lblSecilenSaha.Text);

            //islem türü
            if (lblislemTuru.Text == "KİRALA")
            {
                komut.Parameters.AddWithValue("@islem", "1");
            }
            else
            {
                komut.Parameters.AddWithValue("@islem", "2");
            }

            //ödeme durumu
            if (lblOdemeDurumu.Text == "ÖDENDİ")
            {
                komut.Parameters.AddWithValue("@durum", "1");
            }
            else
            {
                komut.Parameters.AddWithValue("@durum", "2");
            }

            //ödeme türü
            if (lblOdemeDurumu.Text == "NAKİT")
            {
                komut.Parameters.AddWithValue("@tur", "1");
            }
            else
            {
                komut.Parameters.AddWithValue("@tur", "2");
            }

            
            komut.Parameters.AddWithValue("@fiyat", lblFiyat.Text);
            komut.Parameters.AddWithValue("@kayitTarihi", DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();

            //mesaj amacı barındıran form ekranı!
            popupMenu menu = new popupMenu();
            menu.lblMesaj.BackColor = Color.FromArgb(43,178,123);
            menu.lblMesaj.Text = "KAYIT İŞLEMİ BAŞARIYLA GERÇEKLEŞTİ!!";
            menu.ShowDialog(); //XXX show olarak acmıyoruz genelde ard arda kullancagımız formlar varsa 

            //formda kayıt yapıldı sahalar alınıcak gosterılecek yanı formu refresh etmek mantıklı olur!

            foreach (Form item in Application.OpenForms)
            {

                if (item.GetType().Name == "frmKarsilasmaEkrani")
                {
                    //formun acık olup olmadıgını kontrol edıcez cunku acık olmasını ıstemıyoruz

                    item.Close();
                    item.BackColor = Color.FromArgb(240, 240, 240);
                    item.Controls.Clear();
                }
            }
            
            frmKarsilasmaEkrani frm = new frmKarsilasmaEkrani();
            
            frm.ShowDialog();

        }
    }
}
