using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CLProjeDemo2
{
    public class MaasBordro
    {
        public static void BordroOlustur(List<Personel> personelListesi)
        {
            foreach (var personel in personelListesi)
            {
                var maas = personel.MaasHesapla();
                var bordro = new
                {
                    PersonelIsmi = personel.Name,
                    CalismaSaati = personel.CalismaSaati,
                    AnaOdeme = maas,
                    Mesai = personel is Memur ? (maas - (personel.CalismaSaati * personel.SaatlikUcret)) : 0,
                    ToplamOdeme = maas
                };

                var json = JsonConvert.SerializeObject(bordro, Newtonsoft.Json.Formatting.Indented);
                var directory = Path.Combine("Bordrolar", personel.Name);
                Directory.CreateDirectory(directory);
                var filePath = Path.Combine(directory, $"Bordro_{DateTime.Now:yyyy_MM}.json");
                File.WriteAllText(filePath, json);
            }
        }

        public static void RaporYazdir(List<Personel> personelListesi)
        {
            foreach (var personel in personelListesi)
            {
                Console.WriteLine($"Personel: {personel.Name}, Calisma Saati: {personel.CalismaSaati}, Maas: {personel.MaasHesapla()}");
            }

            var azCalisanlar = personelListesi.FindAll(p => p.CalismaSaati < 150);
            Console.WriteLine("\n150 saatten az çalışan personeller:");
            foreach (var personel in azCalisanlar)
            {
                Console.WriteLine($"Personel: {personel.Name}, Calisma Saati: {personel.CalismaSaati}");
            }
        }
    }
}
