using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WP_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            if (tcTxtBox.Text.Equals(""))
            {
                MessageBox.Show("Lütfen TC kimlik numarasını giriniz.");
            }
            else
            {
                DbOperations.musteriSil(tcTxtBox.Text);
            }
        }
    }
}
