using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WP_Project
{
    public partial class Form1 : Form
    {
        public Form1()
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
                if (bilgiler == null)
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                }
                else
                {
                    musteriListView.Items.Add(bilgiler);
                    tcTxtBox.Text = "";
                }
            }
        }       
    }
}
