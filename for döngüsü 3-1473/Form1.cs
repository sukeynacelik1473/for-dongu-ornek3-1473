using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngüsü_3_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            int sayi=Convert.ToInt32(txtSayi.Text);
            lbSayilar.Items.Clear();
            
            for(int i = 1; i <=sayi;  i++)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
