using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Di
{
    public class Poland : ICountry
    {
        public string GetLanguage()
        {
            return "pl-PL";
        }

        public bool ValidateNationalId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
