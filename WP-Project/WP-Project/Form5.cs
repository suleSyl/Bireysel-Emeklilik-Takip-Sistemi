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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        
        private void bulBtn1_Click(object sender, EventArgs e)
        {
            if (tcTxtBox.Text.Equals(""))
            {
                MessageBox.Show("Lütfen TC kimlik numarasını giriniz.");
            }
            else
            {
                ListViewItem bilgiler = DbOperations.ikiListViewItemBirlestir(DbOperations.tcyeGoreMusteriTablosundanBilgiGetir(tcTxtBox.Text), DbOperations.tcyeGoreOdemePlaniTablosundanBilgiGetir(tcTxtBox.Text));
                bilgiler = DbOperations.ikiListViewItemBirlestir(bilgiler, DbOperations.tcyeGoreOdemeTakipTablosundanBilgiGetir(tcTxtBox.Text));
                if (bilgiler == null)
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                }
                else
                {
                    musteriListView.Items.Clear();
                    musteriListView.Items.Add(bilgiler);
                    tcTxtBox.Text = "";
                    odemeBtn.Enabled = true;
                }
            }
        }
       
        private void odemeBtn_Click(object sender, EventArgs e)
        {
            string tc = (string) musteriListView.Items[0].SubItems[0].Text;            
            DbOperations.odemeYap(tc);
            DbOperations.sonOdemeTarihiniGuncelle(tc); // Butona her tıklandığında tarih ödeme periyodu kadar ileri gider!        
            ListViewItem bilgiler = DbOperations.ikiListViewItemBirlestir(DbOperations.tcyeGoreMusteriTablosundanBilgiGetir(tc), DbOperations.tcyeGoreOdemePlaniTablosundanBilgiGetir(tc));
            bilgiler = DbOperations.ikiListViewItemBirlestir(bilgiler, DbOperations.tcyeGoreOdemeTakipTablosundanBilgiGetir(tc));
            if (bilgiler == null)
            {
                MessageBox.Show("Müşteri bulunamadı.");
            }
            else
            {
                musteriListView.Items.Clear();
                musteriListView.Items.Add(bilgiler);
                tcTxtBox.Text = "";
            }
        }

        private void tcTxtBox_TextChanged(object sender, EventArgs e)
        {
            odemeBtn.Enabled = true;
            if (tcTxtBox.Text.Equals(""))
            {
                odemeBtn.Enabled = false;
            }
        }     
    }
}
