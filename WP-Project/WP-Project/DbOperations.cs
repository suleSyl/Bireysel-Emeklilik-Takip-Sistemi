using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WP_Project
{
    public static class DbOperations
    {
        private static string conString = "Data Source=LAPTOP-G9N1KG9M\\SQLEXPRESS;Integrated Security=True";

        public static void dbOlustur()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                // MS Sql'e "Musteriler" adlı bir veritabanı eklenir. (Daha önce ekli olup olmadığı da kontrol edilir)
                SqlCommand cmd = new SqlCommand("If not exists(Select * from sys.databases where name = 'BireyselEmeklilikSistemi') Create database BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static void tabloOlustur()
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                //"Musteriler" veritabanına daha önceden eklenmediyse "Musteri" ve "OdemePlani" tabloları eklenir.
                SqlCommand cmd = new SqlCommand();
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "Use BireyselEmeklilikSistemi";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "If not exists(Select * from sys.tables where name = 'Musteri') Create table Musteri " + "( " + "TC varchar(11) not null, " + "Ad varchar(20), " + "Soyad varchar(50), " + "CepTelefonu varchar(10), " + "SabitTelefon varchar(10), " + "DogumTarihi varchar(10), " + "Eposta varchar(50), " + "Adres varchar(150), " + "Constraint pk_musteri primary key (TC) " + " )";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "If not exists(Select * from sys.tables where name = 'OdemePlani') Create table OdemePlani " + "( " + "TC varchar(11) not null, " + "BaslangicTarihi varchar(15), " + "SonOdemeTarihi varchar(15), " + "OdemePeriyodu varchar(15), " + "OdemeMiktari varchar(15), " + "DevletKatkisi varchar(15), " + "OdemeSekli varchar(25), " + "Constraint pk_odemeplani primary key (TC), " + "Constraint fk_odemeplani foreign key (TC) references Musteri(TC) on delete cascade on update cascade " + " )";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "If not exists(Select * from sys.tables where name = 'OdemeTakip') Create table OdemeTakip " + "( " + "TC varchar(11) not null, " + "BirikenTutar int, " + "Constraint pk_odemetakip primary key (TC), " + "Constraint fk_odemetakip foreign key (TC) references Musteri(TC) on delete cascade on update cascade " + " )";
                cmd.ExecuteNonQuery();
            }
        }

        public static void yeniMusteriEkle(Musteri yeniMusteri)
        {
            // "Müşteri" ve "OdemePlani" tablolarına yeni kayıt eklenmesi
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("use BireyselEmeklilikSistemi", connection);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Insert into Musteri (TC, Ad, Soyad, CepTelefonu, SabitTelefon, DogumTarihi, Eposta, Adres) values (@tc,@ad,@soyad,@ceptelefonu,@sabittelefon,@dogumtarihi,@eposta,@adres)";
                cmd.Parameters.AddWithValue("@tc", yeniMusteri.tc);
                cmd.Parameters.AddWithValue("@ad", yeniMusteri.ad);
                cmd.Parameters.AddWithValue("@soyad", yeniMusteri.soyad);
                cmd.Parameters.AddWithValue("@ceptelefonu", yeniMusteri.cepTel);
                cmd.Parameters.AddWithValue("@sabittelefon", yeniMusteri.sabitTel);
                cmd.Parameters.AddWithValue("@dogumtarihi", yeniMusteri.dogumTarihi);
                cmd.Parameters.AddWithValue("@eposta", yeniMusteri.eposta);
                cmd.Parameters.AddWithValue("@adres", yeniMusteri.adres);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Insert into OdemePlani (TC, BaslangicTarihi, SonOdemeTarihi, OdemePeriyodu, OdemeMiktari, DevletKatkisi, OdemeSekli) values (@tc,@baslangictarihi,@sonodemetarihi,@odemeperiyodu,@odememiktari,@devletkatkisi,@odemesekli)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tc", yeniMusteri.tc);
                cmd.Parameters.AddWithValue("@baslangictarihi", yeniMusteri.odemePlani.baslangicTarihi.ToString());
                cmd.Parameters.AddWithValue("@sonodemetarihi", yeniMusteri.odemePlani.sonOdemeTarihi.ToString());
                cmd.Parameters.AddWithValue("@odemeperiyodu", yeniMusteri.odemePlani.odemePeriyodu.ToString());
                cmd.Parameters.AddWithValue("@odememiktari", yeniMusteri.odemePlani.odemeMiktari.ToString());
                cmd.Parameters.AddWithValue("@devletkatkisi", yeniMusteri.odemePlani.devletKatkisi.ToString());
                cmd.Parameters.AddWithValue("@odemesekli", yeniMusteri.odemePlani.odemeSekli);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Insert into OdemeTakip (TC, BirikenTutar) values (@tc,@birikentutar)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tc", yeniMusteri.tc);
                cmd.Parameters.AddWithValue("@birikentutar", yeniMusteri.odemePlani.birikenTutar);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri başarıyla eklendi.");
            }
        }

        public static ListViewItem tcyeGoreMusteriTablosundanBilgiGetir(string tc)
        {
            //"Musteri" tablosundan Tc numarasına göre aratılıp müşteriye dair bilgilerin çekilmesi
            if (tc == null) { return null; }
            ListViewItem items = new ListViewItem();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select * from Musteri where TC like '%" + tc + "%'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)  // Önce bu TC numarasına sahip müşteri olup olmadığı kontrol edilir.
                {
                    while (reader.Read())
                    {
                        items.Text = reader["TC"].ToString();
                        items.SubItems.Add(reader["Ad"].ToString());
                        items.SubItems.Add(reader["Soyad"].ToString());
                        items.SubItems.Add(reader["CepTelefonu"].ToString());
                        items.SubItems.Add(reader["SabitTelefon"].ToString());
                        items.SubItems.Add(reader["DogumTarihi"].ToString());
                        items.SubItems.Add(reader["Eposta"].ToString());
                        items.SubItems.Add(reader["Adres"].ToString());
                    }
                }
                else { return null; }
            }
            return items;
        }

        public static ListViewItem tcyeGoreOdemePlaniTablosundanBilgiGetir(string tc)
        {
            // "OdemePlani" tablosundan Tc numarasına göre aratılıp ödeme planı detaylarının çekilmesi
            if (tc == null) { return null; }
            ListViewItem items = new ListViewItem();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select * from OdemePlani where TC like '%" + tc + "%'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        items.Text = reader["BaslangicTarihi"].ToString();
                        items.SubItems.Add(reader["SonOdemeTarihi"].ToString());
                        items.SubItems.Add(reader["OdemePeriyodu"].ToString());
                        items.SubItems.Add(reader["OdemeMiktari"].ToString());
                        items.SubItems.Add(reader["DevletKatkisi"].ToString());
                        items.SubItems.Add(reader["OdemeSekli"].ToString());
                    }
                }
                else { return null; }
            }
            return items;
        }

        public static ListViewItem tcyeGoreOdemeTakipTablosundanBilgiGetir(string tc)
        {
            // "OdemeTakip" tablosundan Tc numarasına göre aratılıp biriken tutarın çekilmesi
            if (tc == null) { return null; }
            ListViewItem items = new ListViewItem();
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select * from OdemeTakip where TC like '%" + tc + "%'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        items.Text = reader["BirikenTutar"].ToString();
                    }
                }
                else { return null; }
            }
            return items;
        }

        public static ListViewItem ikiListViewItemBirlestir(ListViewItem musteriBilgi, ListViewItem odemeBilgi)
        {
            if (musteriBilgi == null || odemeBilgi == null)
            {
                return null;
            }
            else
            {
                foreach (ListViewItem.ListViewSubItem s in odemeBilgi.SubItems)  // Müşteri bilgilerine ödeme bilgileri eklenir
                {
                    musteriBilgi.SubItems.Add(s.Text);
                }
                return musteriBilgi;
            }
        }

        public static void musteriTablosuBilgileriniTextBoxaYaz(Form3 f, string tc)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select * from Musteri where TC like '%" + tc + "%'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    f.tcTxtBox2.Text = reader["TC"].ToString();
                    f.adTxtBox2.Text = reader["Ad"].ToString();
                    f.soyadTxtBox2.Text = reader["Soyad"].ToString();
                    f.cepTelTxtBox.Text = reader["CepTelefonu"].ToString();
                    f.sabitTelTxtBox.Text = reader["SabitTelefon"].ToString();
                    f.dGunuTxtBox.Text = reader["DogumTarihi"].ToString();
                    f.epostaTxtBox.Text = reader["Eposta"].ToString();
                    f.adresTxtBox.Text = reader["Adres"].ToString();
                }
            }
        }

        public static void odemePlaniTablosuBilgileriniTextBoxaYaz(Form3 f, string tc)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select * from OdemePlani where TC like '%" + tc + "%'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    f.baslangicTarihiDTPicker.Text = reader["BaslangicTarihi"].ToString();
                    f.sonOdemeDTPicker.Text = reader["SonOdemeTarihi"].ToString();
                    f.periyodComboBox.Text = reader["OdemePeriyodu"].ToString();
                    f.miktarTxtBox.Text = reader["OdemeMiktari"].ToString();
                    f.devletKTxtBox.Text = reader["DevletKatkisi"].ToString();
                    f.odemeSekliTxtBox.Text = reader["OdemeSekli"].ToString();
                }
                else { MessageBox.Show("Müşteri bulunamadı!!"); }
            }
        }

        public static void musteriTablosunuGuncelle(Form3 f, string tc)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Update Musteri set TC=@tc, Ad=@ad, Soyad=@soyad, CepTelefonu=@ceptelefonu, SabitTelefon=@sabittelefon, DogumTarihi=@dogumtarihi, Eposta=@eposta, Adres=@adres where TC like '%" + tc + "%'";
                cmd.Parameters.AddWithValue("@tc", f.tcTxtBox2.Text);
                cmd.Parameters.AddWithValue("@ad", f.adTxtBox2.Text);
                cmd.Parameters.AddWithValue("@soyad", f.soyadTxtBox2.Text);
                cmd.Parameters.AddWithValue("@ceptelefonu", f.cepTelTxtBox.Text);
                cmd.Parameters.AddWithValue("@sabittelefon", f.sabitTelTxtBox.Text);
                cmd.Parameters.AddWithValue("@dogumtarihi", f.dGunuTxtBox.Text.Replace(" ", ""));
                cmd.Parameters.AddWithValue("@eposta", f.epostaTxtBox.Text);
                cmd.Parameters.AddWithValue("@adres", f.adresTxtBox.Text);
                cmd.ExecuteNonQuery();
            }
        }

        public static void odemePlaniTablosunuGuncelle(Form3 f, string tc)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Update OdemePlani set OdemePeriyodu=@odemeperiyodu, OdemeMiktari=@odememiktari, DevletKatkisi=@devletkatkisi, OdemeSekli=@odemesekli where TC like '%" + tc + "%'";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@odemeperiyodu", f.periyodComboBox.Text);
                cmd.Parameters.AddWithValue("@odememiktari", f.miktarTxtBox.Text);
                cmd.Parameters.AddWithValue("@devletkatkisi", f.devletKTxtBox.Text);
                cmd.Parameters.AddWithValue("@odemesekli", f.odemeSekliTxtBox.Text);
                cmd.ExecuteNonQuery();
            }
        }

        public static void odemeYap(string tc)
        {
            // Ödeme yaptığında müşterinin hesabındaki tutarın artırılması
            string odemeMiktari = null;
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Select OdemeMiktari from [OdemePlani] where TC=@tc";
            cmd.Parameters.AddWithValue("@tc", tc);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    odemeMiktari = (string)reader["OdemeMiktari"];
                }
            }
            reader.Close();
            cmd.CommandText = "Update OdemeTakip set BirikenTutar = BirikenTutar + @odememiktari + @odememiktari/4 where TC like '%" + tc + "%'";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@odememiktari", odemeMiktari);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void sonOdemeTarihiniGuncelle(string tc)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string sonOdeme = null;
                string odemePer = null;
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select SonOdemeTarihi, OdemePeriyodu from [OdemePlani] where TC=@tc";
                cmd.Parameters.AddWithValue("@tc", tc);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sonOdeme = (string)reader["SonOdemeTarihi"];
                        odemePer = (string)reader["OdemePeriyodu"];
                    }
                }
                reader.Close();
                DateTime sonOdemeTarihi = Convert.ToDateTime(sonOdeme);
                int odemePeriyodu = Convert.ToInt32(odemePer);
                switch (odemePeriyodu)
                {
                    case 1:
                        sonOdemeTarihi = sonOdemeTarihi.AddMonths(12);
                        break;
                    case 3:
                        sonOdemeTarihi = sonOdemeTarihi.AddMonths(4);
                        break;
                    case 6:
                        sonOdemeTarihi = sonOdemeTarihi.AddMonths(2);
                        break;
                    case 12:
                        sonOdemeTarihi = sonOdemeTarihi.AddMonths(1);
                        break;
                }
                if (sistemdeKalmaSuresiniBul(tc) == 10)
                {
                    MessageBox.Show("Müşteri sistemde en az 10 yılını doldurmuş bulunmaktadır. Dilerse hesabında biriken tutarı çekebilir.");
                }
                sonOdeme = sonOdemeTarihi.ToString("dd/MM/yyyy");
                cmd.CommandText = "Update OdemePlani set SonOdemeTarihi = @sonodemetarihi where TC like '%" + tc + "%'";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sonodemetarihi", sonOdeme);
                cmd.ExecuteNonQuery();
            }
        }

        public static int sistemdeKalmaSuresiniBul(string tc)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string baslangicTarihi = null, sonOdemeTarihi = null;
                TimeSpan fark; DateTime baslangicTar, sonOdemeTar; int aradakiFark, aradakiYil;
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select BaslangicTarihi, SonOdemeTarihi from [OdemePlani] where TC=@tc";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tc", tc);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        baslangicTarihi = (string)reader["BaslangicTarihi"];
                        sonOdemeTarihi = (string)reader["SonOdemeTarihi"];
                    }
                    reader.Close();
                    baslangicTar = Convert.ToDateTime(baslangicTarihi);
                    sonOdemeTar = Convert.ToDateTime(sonOdemeTarihi);
                    fark = sonOdemeTar - baslangicTar;
                    aradakiFark = int.Parse(fark.Days.ToString());
                    aradakiYil = aradakiFark / 365;
                    return aradakiYil;
                }
                else { return -1; }
            }
        }

        public static void musteriSil(string tc)
        {   // Müşteri kaydının silinmesi
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand cmd = new SqlCommand("Use BireyselEmeklilikSistemi", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * from Musteri where TC=@tc";
                cmd.Parameters.AddWithValue("@tc", tc);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string isim = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
                    reader.Close();
                    DialogResult durum = MessageBox.Show(isim + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == durum)
                    {
                        cmd.CommandText = "DELETE from Musteri where TC=@tc";  // Foreign key tanımlandığı için tek bir tablodan silinince diğer tablolardan da silinmektedir.
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@tc", tc);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt silindi.");
                    }
                }
                else
                {
                    MessageBox.Show("Müşteri Bulunamadı.");
                }
            }
        }
    }
}

