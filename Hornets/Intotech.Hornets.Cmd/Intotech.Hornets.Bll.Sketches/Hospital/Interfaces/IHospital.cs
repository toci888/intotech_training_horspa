using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Hospital.Interfaces
{
    public interface IHospital<TDomains> where TDomains : IEnumerable<IDomain<IPatient>>
    {
        
    }
}
