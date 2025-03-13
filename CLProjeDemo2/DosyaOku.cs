using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLProjeDemo2
{
    public class DosyaOku
    {
        public static List<Personel> JsonDosyasindanOku(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new PersonelConverter());
            var personelListesi = JsonConvert.DeserializeObject<List<Personel>>(json, settings);
            return personelListesi;
        }
    }
}
