using Microsoft.VisualStudio.TestTools.UnitTesting;
using WP_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WP_Project.Tests
{
    [TestClass()]
    public class DbOperationsTests
    {
        [TestMethod()]
        public void veritabanınaBaglaniyorMuTest()
        {
            string conString = "Data Source=LAPTOP-G9N1KG9M\\SQLEXPRESS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conString);
            Assert.IsNotNull(connection);
        }            
        
        [TestMethod()]
        public void tcyeGoreOdemeTakipTablosundanBilgiGetirTest()
        {
            ListViewItem items = new ListViewItem();
            items.Text = "625";  //Ödeme takip tablosundaki biriken tutar değeri
            string tc = "36232323232";
            ListViewItem expected = DbOperations.tcyeGoreOdemeTakipTablosundanBilgiGetir(tc);
            Assert.AreEqual(expected.Text, items.Text);
        }

        [TestMethod]
        public void musteriyiSilinceDatabasedeBilgiKalmamışOlsun()
        {
            string tc = "39125452010";
            DbOperations.musteriSil(tc);
            ListViewItem expected = DbOperations.tcyeGoreMusteriTablosundanBilgiGetir(tc);
            Assert.IsNull(expected);
        }
    }
}