using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intotech.Sparrows.Cmd;

namespace Intotech.Sparrows.Cmd
{
    public class CollectionUtils
    {
        // pobieramy pesel, wyciagamy miesiac, zwracamy nazwe miesiaca dla jego numeru z pesel
        // 08 ? Sierpien
        public string GetMonthNameFromPesel(string pesel) //89101112345
        {
            //01234
            //84080818074
            string monthFromPesel = pesel.Substring(2, 2);

            if (monthFromPesel == "08")
            {
                return "Sierpień";
            }

            if (monthFromPesel == "10")
            {
                return "Październik";
            }

            return "";
        }
    }
}
