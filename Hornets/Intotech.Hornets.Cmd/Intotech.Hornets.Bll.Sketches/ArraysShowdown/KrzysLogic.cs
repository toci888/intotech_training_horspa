using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.ArraysShowdown
{
    public class KrzysLogic : SubjectLogic
    {
        public override void FilterEntities(int id, string title, string subject)
        {
            //??
            // 
            subjectEntities.Where(se => se.Title.Contains("bajki") || se.Subject.Contains("kota"));

            // Krzys - titile 'bajki' lub subject 'kota'
            // Robert - id > 1 i subject 'rek'
        }
    }
}
