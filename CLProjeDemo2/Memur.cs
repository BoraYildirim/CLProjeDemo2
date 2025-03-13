using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLProjeDemo2
{
    public class Memur : Personel
    {
        public override decimal MaasHesapla()
        {
            decimal anaOdeme = 0;
            decimal mesaiOdeme = 0;

            if (CalismaSaati > 180)
            {
                anaOdeme = 180 * SaatlikUcret;
                mesaiOdeme = (CalismaSaati - 180) * (SaatlikUcret * 1.5m);
            }
            else
            {
                anaOdeme = CalismaSaati * SaatlikUcret;
            }

            return anaOdeme + mesaiOdeme;
        }
    }
}
