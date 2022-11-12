using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.ArraysShowdown
{
    public class SubjectEntity
    {
        public string Subject { get; set; } 
        public string Title { get; set; }
        public int Id { get; set; }

        public override bool Equals(object? obj)
        {
            SubjectEntity se = (SubjectEntity)obj;

            return Subject == se.Subject && Title == se.Title && Id == se.Id;
        }
    }
}
