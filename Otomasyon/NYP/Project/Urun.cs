using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Urun
    {
        public string Isim { get; set; }
        public decimal Fiyat { get; set; }
        public double Agirlik { get; set; }
        public int Adet { get; set; }

        public Urun(string Isim, decimal Fiyat, double Agirlik, int Adet)
        {
            this.Isim = Isim;
            this.Fiyat = Fiyat;
            this.Agirlik = Agirlik;
            this.Adet = Adet;
        }

        public Urun()
        {
        }

        public decimal toplamBrutFiyat(int adet)
        {
            return this.Fiyat * adet;
        }

        public double toplamAgirlik(int adet)
        {
            return this.Agirlik * adet;
        }

        public override string ToString()
        {
            return Isim + Fiyat + Agirlik;
        }
    }
}