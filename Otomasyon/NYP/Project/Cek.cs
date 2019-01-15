using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Cek : Odeme
    {
        public string BankID { get; set; }
        public string Isim { get; set; }

        public override bool Dogrulama()
        {
            if (BankID == "" || Isim == "")
            {
                MessageBox.Show("Banka Bilgileri Hatalı! Ödeme Onaylanmadı.");
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
