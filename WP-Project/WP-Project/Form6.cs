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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void odemeYapBtn_Click(object sender, EventArgs e)
        {
            int sistemdeKalmaSuresi;
            if (tcTxtBox.Text.Equals(""))
            {
                MessageBox.Show("Lütfen TC kimlik numarasını giriniz.");
            }
            else
            {
                sistemdeKalmaSuresi = DbOperations.sistemdeKalmaSuresiniBul(tcTxtBox.Text);
                if (sistemdeKalmaSuresi == -1)
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                } else if (sistemdeKalmaSuresi >= 10)
                {
                    MessageBox.Show("Müşteri biriktirdiği toplam parayı çekebilir");
                    DbOperations.musteriSil(tcTxtBox.Text);
                } else if (sistemdeKalmaSuresi < 10)
                {
                    MessageBox.Show("Maalesef bir kişinin emeklilik hakkı kazanması için sistemde en az 10 yıl kalması gerekir.");
                }
            }
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tcTxtBox_TextChanged(object sender, EventArgs e)
        {
            odemeYapBtn.Enabled = true;
            if (tcTxtBox.Text.Equals(""))
            {
                odemeYapBtn.Enabled = false;
            }
        }
    }
}
