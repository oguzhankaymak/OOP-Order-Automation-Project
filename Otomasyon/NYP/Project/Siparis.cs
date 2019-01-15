using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Siparis
    {
        public DateTime Tarih { get; set; }
        public Boolean Durum { get; set; }
        public SiparisDetayi SiparisDetay { get; set; }

        public Siparis(DateTime tarih)
        {
            this.Tarih = tarih;
        }

        public Siparis()
        {
        }

        public decimal vergiHesapla(decimal brutFiyat)
        {
            return brutFiyat * 0.18m;
        }

        public decimal toplamFiyat(decimal brutFiyat)
        {
            return brutFiyat + vergiHesapla(brutFiyat);
        }

        public double agirlikHesapla(double agirlik, int adet)
        {
            return agirlik * adet;
        }
    }
}