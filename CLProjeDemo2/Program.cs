using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLProjeDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "personel.json";
            List<Personel> personelListesi = DosyaOku.JsonDosyasindanOku(filePath);

            MaasBordro.BordroOlustur(personelListesi);
            MaasBordro.RaporYazdir(personelListesi);
        }
    }
}
