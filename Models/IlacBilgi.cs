using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class IlacBilgi
    {
        public int IlacID { get; set; }
        public int IlacKodu { get; set; }
        public string Ad { get; set; }
        public string Fiyat { get; set; }
        public string U_firma { get; set; }
        public string Amac { get; set; }
        public int KutuSayi { get; set; }

        public ICollection<HastaIlac> EczanedekiIlaclar { get; set; }
    }
}
