using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Json
{
    public class JsonHwModel
    {
       public string Animals { get; set; }
        public string Titles { get; set; }        
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Bajki
    {
        public string title { get; set; }
        public string subject { get; set; }
    }

    public class RootCartoons
    {
        public List<Bajki> bajki { get; set; }
    }


}