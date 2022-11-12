using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Json
{
    public class JsonHwLogic
    {
        protected List<JsonHwModel> GetCartoons(string json)
        {
            RootCartoons deserializedCartoons = JsonSerializer.Deserialize<RootCartoons>(json);

            List<JsonHwModel> listCartoons = new List<JsonHwModel>();

            foreach (Bajki item in deserializedCartoons.bajki)
            {
                JsonHwModel jsonHwModel = new JsonHwModel();

                jsonHwModel.Animals = item.subject;

                jsonHwModel.Titles = item.title;

                listCartoons.Add(jsonHwModel);
            }

            return listCartoons;
        }

        public List<JsonHwModel> RunDeserializationHw()
        {
            return GetCartoons(File.ReadAllText(@"../../../../Intotech.Hornets.Bll.Sketches/Json/robertjsonhw.txt"));
        }
    }
}