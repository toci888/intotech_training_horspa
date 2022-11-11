using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Json
{
    public class DevsModel
    {
        public string Name { get; set; }
        public string[] Skills { get; set; }
    }

    public class Rootobject
    {
        public Programisci[] Programisci { get; set; }
    }

    public class Programisci
    {
        public string dev { get; set; }
        public Skill[] skills { get; set; }
    }

    public class Skill
    {
        public string skill { get; set; }
    }
}
