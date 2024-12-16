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
    public partial class popupMenu : Form
    {
        public popupMenu()
        {
            InitializeComponent();
        }
        int sayac = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 10) { 

                this.Close();
                      
            }
        }
    }
}
