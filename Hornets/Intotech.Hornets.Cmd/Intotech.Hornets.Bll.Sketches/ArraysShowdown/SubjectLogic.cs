using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.ArraysShowdown
{
    public class SubjectLogic
    {
        protected SubjectEntity[] subjectEntities = new SubjectEntity[] { 
            new SubjectEntity() { Id = 1, Title = "tytul filmu", Subject = "ala ma kota" },
            new SubjectEntity() { Id = 2, Title = "tytul bajki", Subject= "reksio" }
        };

        public virtual void FilterEntities(int id, string title, string subject)
        {
            //List<SubjectEntity> result = subjectEntities.Where(el => el.Title.Contains("bajki") && el.Subject).ToList();
        }

        public bool AreSame(SubjectEntity entity)
        {
            SubjectEntity result = subjectEntities.Where(ent => ent.Equals(entity)).FirstOrDefault();
            
            return result != null;
        }
    }
}
