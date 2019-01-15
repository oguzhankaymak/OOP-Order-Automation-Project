using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SiparisDetayi
    {
        public int Adet { get; set; }
        public Boolean VergiDurumu { get; set; }

        public SiparisDetayi(int adet, Boolean VergiDurumu)
        {
            this.Adet = Adet;
            this.VergiDurumu = VergiDurumu;
        }

        public SiparisDetayi()
        {
        }
    }
}
