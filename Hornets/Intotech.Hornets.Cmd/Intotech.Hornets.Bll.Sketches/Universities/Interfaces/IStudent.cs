using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Universities.Interfaces
{
    public interface IStudent
    {
        ISubject subject { get; set;  }

        IFaculty<IStudent> GetSubjects();
    }
}
