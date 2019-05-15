using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Project
{
    public class Odeme
    {
        public string baslangicTarihi;
        public string sonOdemeTarihi;
        public int odemePeriyodu;
        public double odemeMiktari;
        public double devletKatkisi;
        public string odemeSekli;
        public int birikenTutar;

        public Odeme(string baslangictarihi, string sonodemetarihi, int periyod, double miktar, double devletkatkisi, string odemesekli, int birikentutar)
        {
            this.baslangicTarihi = baslangictarihi;
            this.sonOdemeTarihi = sonodemetarihi;
            this.odemePeriyodu = periyod;
            this.odemeMiktari = miktar;
            this.devletKatkisi = devletkatkisi;
            this.odemeSekli = odemesekli;
            this.birikenTutar = birikentutar;
        }

        public Odeme(string baslangictarihi, int periyod, double miktar, double devletkatkisi, string odemesekli)
        {
            this.baslangicTarihi = baslangictarihi;
            this.odemePeriyodu = periyod;
            this.odemeMiktari = miktar;
            this.devletKatkisi = devletkatkisi;
            this.odemeSekli = odemesekli;
        }

    }
}
