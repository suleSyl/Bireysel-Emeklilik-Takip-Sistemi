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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static List<string> odemeSekilleri = new List<string>();

        private void Form3_Load(object sender, EventArgs e)
        {
            OdemeSekilleriXml.xmlDosyasıOlustur();
            OdemeSekilleriXml.odemeSekilleriniXmleYaz();
            odemeSekilleri = OdemeSekilleriXml.odemeSekilleriniOku();
            foreach (string s in odemeSekilleri)
            {
                odemeSekliTxtBox.Items.Add(s);
            }
        }

        private void bulBtn1_Click(object sender, EventArgs e)
        {
            if (tcTxtBox.Text.Equals(""))
            {
                MessageBox.Show("Lütfen TC kimlik numarasını giriniz.");
            }
            else
            {
                DbOperations.musteriTablosuBilgileriniTextBoxaYaz(this, tcTxtBox.Text);
                DbOperations.odemePlaniTablosuBilgileriniTextBoxaYaz(this, tcTxtBox.Text);
            }
        }        

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            DbOperations.musteriTablosunuGuncelle(this, tcTxtBox.Text);
            DbOperations.odemePlaniTablosunuGuncelle(this, tcTxtBox2.Text);
            MessageBox.Show("Müşteri bilgileri başarıyla güncellendi");
            EkraniTemizle.Temizle(this.Controls);
        }

        private void hesaplaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double odemeMiktari = Convert.ToDouble(miktarTxtBox.Text);
                double devletKatkisi = odemeMiktari / 4;
                devletKTxtBox.Text = devletKatkisi.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen tekrar deneyiniz.\n\n" + ex);
            }
        }

        private void tcTxtBox_TextChanged(object sender, EventArgs e)
        {
            guncelleBtn.Enabled = true;
            if (tcTxtBox.Text.Equals(""))
            {
                guncelleBtn.Enabled = false;
            }
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
