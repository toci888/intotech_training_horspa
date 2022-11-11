using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Json
{
    public class JsonLogic
    {
        protected List<DevsModel> GetDevs(string json)
        {
           Rootobject deserialized =  JsonSerializer.Deserialize<Rootobject>(json);

            List<DevsModel> listDevs = new List<DevsModel>();

            foreach (Programisci item in deserialized.Programisci)
            {
                DevsModel model = new DevsModel();

                model.Name = item.dev;

                model.Skills = item.skills?.Select(m => m.skill).ToArray();

                listDevs.Add(model);
            }

            return listDevs;
        }

        public List<DevsModel> RunDeserialization()
        {
            return GetDevs(File.ReadAllText(@"../../../../Intotech.Hornets.Bll.Sketches/Json/jsondevs.txt"));
        }

     

        public List<DevsModel> RunDeserializationRob()
        {
            return GetDevs(File.ReadAllText(@"../../../../Intotech.Hornets.Bll.Sketches/Json/jsondevsRob.txt"));
        }
    }
}
