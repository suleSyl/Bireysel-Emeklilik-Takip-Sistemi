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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static List<string> odemeSekilleri = new List<string>();

        private void Form2_Load(object sender, EventArgs e)
        {
            OdemeSekilleriXml.xmlDosyasıOlustur();
            OdemeSekilleriXml.odemeSekilleriniXmleYaz();
            odemeSekilleri = OdemeSekilleriXml.odemeSekilleriniOku();
            foreach(string s in odemeSekilleri)
            {
                odemeSekliTxtBox.Items.Add(s);
            }
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

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Odeme yeniOdeme = new Odeme(baslangicTarihiDTPicker.Value.ToString("dd-MM-yyyy"), sonOdemeDTPicker.Value.ToString("dd-MM-yyyy"), int.Parse(periyodComboBox.Text), double.Parse(miktarTxtBox.Text), double.Parse(devletKTxtBox.Text), odemeSekliTxtBox.Text.ToString(), 0);
                Musteri yeniMusteri = new Musteri(tcTxtBox.Text.ToString(), adTxtBox.Text.ToString(), soyadTxtBox.Text.ToString(), cepTelTxtBox.Text.ToString(), sabitTelTxtBox.Text.ToString(), dGunuTxtBox.Text.Replace(" ", "").ToString(), yeniOdeme, epostaTxtBox.Text.ToString(), adresTxtBox.Text.ToString());
                DbOperations.yeniMusteriEkle(yeniMusteri);
                EkraniTemizle.Temizle(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen girdiğiniz bilgileri kontrol edip tekrar deneyiniz.\n\n" + ex);
            }            
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
