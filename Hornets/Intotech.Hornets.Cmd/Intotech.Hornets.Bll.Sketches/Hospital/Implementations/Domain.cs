using Intotech.Hornets.Bll.Sketches.Hospital.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.Hospital.Implementations
{
    public class Domain : IDomain<IPatient>
    {
        public bool AddPatient(IPatient patient)
        {
            patient.GetDiagnosis();

            return true;
        }

        public string GetDomain()
        {
            throw new NotImplementedException();
        }
    }
}
