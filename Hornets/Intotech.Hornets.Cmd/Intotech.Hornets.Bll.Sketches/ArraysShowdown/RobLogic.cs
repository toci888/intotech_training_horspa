using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.ArraysShowdown
{
    public class RobLogic : SubjectLogic
    {
        public override void FilterEntities(int id, string title, string subject)
        {
            List<SubjectEntity> result = subjectEntities.Where(el => el.Id > 1 && el.Subject.Contains("rek")).ToList();
        }
    }
}
