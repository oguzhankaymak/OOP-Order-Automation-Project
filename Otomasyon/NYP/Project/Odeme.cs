using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nakit,Kredi Kartıve Çek ödeme sınıflarının kalıtım aldığı abstract(soyut) sınıfımız
//Her ödeme tipi sınıfı bu sınıftan miras aldığı Dogrulama() soyut metodunu kendilerine göre ezecektir.
namespace Project
{
    public abstract class Odeme
    {
        public decimal Fiyat { get; set; }

        public abstract bool Dogrulama();
    }
}
