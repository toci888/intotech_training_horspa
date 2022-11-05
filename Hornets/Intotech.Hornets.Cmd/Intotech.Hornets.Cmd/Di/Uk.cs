using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Di
{
    public class Uk : ICountry
    {
        public string GetLanguage()
        {
            return "gb-GB";
        }

        public bool ValidateNationalId(string id)
        {
            throw new NotImplementedException();
        }
    }
}
