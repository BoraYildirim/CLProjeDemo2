using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLProjeDemo2
{
    public abstract class Personel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int CalismaSaati { get; set; }
        public decimal SaatlikUcret { get; set; }

        public abstract decimal MaasHesapla();
    }
}
