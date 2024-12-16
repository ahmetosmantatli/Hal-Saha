using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class sahalar : UserControl
    {
        public sahalar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (Form item in Application.OpenForms) {

                if (item.GetType().Name =="frmSahaListesi") {
                    //formun acık olup olmadıgını kontrol edıcez cunku acık olmasını ıstemıyoruz

                    item.Close();
                    item.BackColor = Color.FromArgb(    240,240,240);
                    item.Controls.Clear();
                }
            
            }
            frmSahaBilgiDuzenlemeEkrani frm = new frmSahaBilgiDuzenlemeEkrani();
            frm.gelenKod = lblSahaNumarasi.Text;
            frm.ShowDialog(); 
        }

        private void lblSahaNumarasi_Click(object sender, EventArgs e)
        { //sımdılık ıgnore 

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.CornflowerBlue;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(64,64,64);
        }
    }
}
