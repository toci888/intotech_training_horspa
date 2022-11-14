using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Universities.Interfaces
{
    public interface IUniversity<TFaculties> where TFaculties : IEnumerable<IFaculty<IStudent>>
    {

    }
}
