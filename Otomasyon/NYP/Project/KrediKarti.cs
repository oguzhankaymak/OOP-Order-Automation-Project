using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Odeme sınıfından miras aldığımız Dogrulama() metodunu ezerek belirli kısıtlamalar getirdik.
namespace Project
{
    public class KrediKarti : Odeme
    {
        public string Numara { get; set; }
        public int Cvv { get; set; }
        public int SonAy { get; set; }
        public int SonYıl { get; set; }

        public override bool Dogrulama()
        {
            if (Numara.Length != 16 || Cvv.ToString().Length != 3 || SonAy <= 0 || SonAy >= 13 || SonYıl < 2018 || SonYıl > 2100)
            {
                MessageBox.Show("Kart Bilgileri Hatalı! Ödeme Onaylanmadı.");
                return false;
            }
            else
            {
                MessageBox.Show("Ödeme Onaylandı.");
                return true;
            }

        }
    }
}
