using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLProjeDemo2
{
    public class Yonetici : Personel
    {
        public decimal Bonus { get; set; }

        public override decimal MaasHesapla()
        {
            if (SaatlikUcret < 500)
            {
                SaatlikUcret = 500;
            }
            return (CalismaSaati * SaatlikUcret) + Bonus;
        }
    }
}
