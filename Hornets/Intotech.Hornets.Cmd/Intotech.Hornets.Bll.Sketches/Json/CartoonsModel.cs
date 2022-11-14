
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Json
{
    public class CartoonsModel
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
    }

    public class RootCartoonsobject
    {
        public Bajki[] bajki { get; set; }
    }

    public class Bajki
    {
        public string title { get; set; }
        public string subject { get; set; }
    }
}
