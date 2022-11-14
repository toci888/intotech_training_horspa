using Intotech.Hornets.Bll.Sketches.Universities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Universities.Implementations
{
    public class Faculty : IFaculty<IStudent>
    {
        public bool AddStudent(IStudent student)
        {
            student.GetSubjects();

            return true;
        }

        public string GetFaculty()
        {
            throw new NotImplementedException();
        }
    }
}
