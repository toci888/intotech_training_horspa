using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Di
{
    public class Logic
    {
        protected ICountry Country;
        public Logic(ICountry country)
        {
            Country = country;
        }

        public void SaveNationalId(string id)
        {
            if (Country.ValidateNationalId(id))
            {
                
            }
        }
    }
}
