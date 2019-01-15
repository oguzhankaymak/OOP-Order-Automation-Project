using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class UrunlerListesi
    {

        public List<Urun> Urunler { get; set; } = new List<Urun>();              

        public void UrunEkle(Urun urun)           // Urunler listesine parametre olarak gelen urun ekleniyor.
        {   
            Urunler.Add(urun);
        }

        public void UrunSil(Urun urun)            // Urunler listesinden parametre olarak gelen urun siliniyor. 
        {
            Urunler.RemoveAt(Urunler.IndexOf(urun));
        }

        public void UrunSil(int index)          // Urunler listesinden parametre olarak gelen indexteki urun siliniyor.    
        {
            Urunler.RemoveAt(index);
        }
    }
}
