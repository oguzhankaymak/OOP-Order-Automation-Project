using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Odeme sınıfından miras alan Nakit sınıfımızda Dogrulama() Nakit Ödeme senaryosuna göre metodunu ezdik.
namespace Project
{
    public class Nakit : Odeme
    {
        public decimal VerilenNakit { get; set; }

        public override bool Dogrulama()
        {
            if (VerilenNakit < Fiyat)
            {
                MessageBox.Show("Girilen tutar yetersiz!");
                return false;
            }
            else if (VerilenNakit == Fiyat)
            {
                MessageBox.Show("Ödeme başarılı.");
                return true;
            }
            else
            {
                decimal geriVerilen = VerilenNakit - Fiyat;
                MessageBox.Show("Ödeme başarılı. Geri verilen tutar: " + geriVerilen.ToString());
                return true;
            }

        }
    }
}
