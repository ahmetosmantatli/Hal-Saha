using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class SahaKontrol : UserControl
    {
        public SahaKontrol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");
        private void SahaKontrol_Load(object sender, EventArgs e)
        {
            //veri cekicez sorgulama amaclı kullanım yapıcaz!
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Kayitlar where tarih=@tarih AND saat=@saat AND saha=@saha", baglanti);
            komut.Parameters.AddWithValue("@tarih", lblTarih.Text.Trim());
            komut.Parameters.AddWithValue("@saat", lblSaat.Text.Trim());
            komut.Parameters.AddWithValue("@saha", "48100"); //degistiricem saha 1ın kodu bu manuel gırdım dınamık hale getırcem saha2 ait
            SqlDataReader oku  = komut.ExecuteReader();
            if (oku.Read()) //tekli sorgulama islemi yapıcam while gerektirmez!
            {
                this.BackColor = Color.Red;
            }

            baglanti.Close();
        }


        private void lblSaat_Click(object sender, EventArgs e)
        {
            //ignore
        }
    }
}
