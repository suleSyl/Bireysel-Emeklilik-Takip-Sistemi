using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_Project
{    public class Musteri
    {
        public string tc;
        public string ad;
        public string soyad;
        public string cepTel;
        public string sabitTel;        
        public string dogumTarihi;
        public Odeme odemePlani;
        public string eposta;
        public string adres;

        public Musteri(string tc, string ad, string soyad, string ceptel, string sabittel, string dogumtarihi, Odeme odeme, string eposta, string adres)
        {
            this.tc = tc;
            this.ad = ad;
            this.soyad = soyad;
            this.cepTel = ceptel;
            this.sabitTel = sabittel;            
            this.dogumTarihi = dogumtarihi;
            this.odemePlani = odeme;
            this.eposta = eposta;
            this.adres = adres;
        }
    }
}
