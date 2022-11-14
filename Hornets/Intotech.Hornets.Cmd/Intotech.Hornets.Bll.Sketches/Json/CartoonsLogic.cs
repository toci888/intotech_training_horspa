using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Json
{
    public class CartoonsLogic
    {
        protected List<CartoonsModel> GetCartoons(string json)
        {
            RootCartoonsobject deserializedCartoons = JsonSerializer.Deserialize<RootCartoonsobject>(json);

            List<CartoonsModel> listCartoons = new List<CartoonsModel>();

            foreach (Bajki item in deserializedCartoons.bajki)
            {
                CartoonsModel cartoonsModel = new CartoonsModel();

                cartoonsModel.ShortDescription = item.subject;

                cartoonsModel.Title = item.title;

                listCartoons.Add(cartoonsModel);
            }

            return listCartoons;
        }

        public List<CartoonsModel> RunDeserializationHw()
        {
            return GetCartoons(File.ReadAllText(@"../../../../Intotech.Hornets.Bll.Sketches/Json/robertjsonhw.txt"));
        }
    }
}