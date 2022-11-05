using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Di
{
    public interface ICountry
    {
        string GetLanguage();

        bool ValidateNationalId(string id);

    }
}
