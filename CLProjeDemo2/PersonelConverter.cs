using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CLProjeDemo2
{
    internal class PersonelConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Personel));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);
            var type = (string)jsonObject["Type"];
            Personel personel;

            switch (type)
            {
                case "Memur":
                    personel = new Memur();
                    break;
                case "Yonetici":
                    personel = new Yonetici();
                    break;
                default:
                    throw new Exception("Unknown type");
            }

            serializer.Populate(jsonObject.CreateReader(), personel);
            return personel;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
