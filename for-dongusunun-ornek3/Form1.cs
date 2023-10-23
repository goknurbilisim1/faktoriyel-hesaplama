using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_dongusunun_ornek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
           { int sayi=Convert.ToInt32(txtSayi.Text);
            int sonuc = 1;

            for (int i = 1; i <=sayi; i++)
                {
                    sonuc*= i;
                }
            lblSonuc.Text="Sonuç: "+sonuc;

            

            
            

            }

        } 
    }
}
