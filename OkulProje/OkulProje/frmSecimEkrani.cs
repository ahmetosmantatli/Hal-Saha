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
    public partial class frmSecimEkrani : Form
    {
        public frmSecimEkrani()
        {
            InitializeComponent();
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSahaKayitEkrani frm = new frmSahaKayitEkrani();
            frm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //önce liste ekranına gıdıcez saha idsinden veri bilgilerini cekmeliyiz
            frmSahaYonlendirmEkrani frm = new frmSahaYonlendirmEkrani();
            frm.ShowDialog();
            
        }
    }
}
