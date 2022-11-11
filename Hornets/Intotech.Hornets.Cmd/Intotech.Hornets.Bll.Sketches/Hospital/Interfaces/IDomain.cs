using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Hospital.Interfaces
{
    public interface IDomain<TPatient> where TPatient : IPatient
    {
        string GetDomain();

        bool AddPatient(TPatient patient);
    }
}
