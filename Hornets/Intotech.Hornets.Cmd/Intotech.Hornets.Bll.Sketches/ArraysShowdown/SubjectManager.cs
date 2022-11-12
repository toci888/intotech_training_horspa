using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.ArraysShowdown
{
    public class SubjectManager
    {
        protected Dictionary<string, SubjectLogic> map = new Dictionary<string, SubjectLogic>()
        {
            { "default", new SubjectLogic() },
            { "robert", new RobLogic() },
            { "krzys", new KrzysLogic() },
            { "bartek", new BartekLogic() },
        };

        protected SubjectEntity Se = new SubjectEntity();

        protected Dictionary<string, Func<SubjectEntity, string, SubjectEntity>> mapSe = new Dictionary<string, Func<SubjectEntity, string, SubjectEntity>>()
        {
            { "title", (se, val) => { se.Title = val; return se; } }
        };

        public void MapSe(string key, string val)
        {
            if (mapSe.ContainsKey(key))
            {
                Se = mapSe[key](Se, val);
            }
        }

        public void Run(string key, int id, string title, string subject)
        {
            if (map.ContainsKey(key))
            {
                map[key].FilterEntities(id, title, subject);
            }
        }

        public void LuckyRun(string wildcard)
        {
            map.Where(x => x.Key.Contains(wildcard)); // e => 3 logiki
        }
    }
}
