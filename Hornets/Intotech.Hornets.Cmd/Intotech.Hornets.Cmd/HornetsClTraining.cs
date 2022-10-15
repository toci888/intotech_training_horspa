using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd
{
    public class HornetsClTraining
    {
        public void First()
        {
            int nothing = ThisIsASimpleCl.peselLength;

            ThisIsASimpleCl peselone = new ThisIsASimpleCl();

            peselone.Pesel = "84080818074";
            //ThisIsASimpleCl.Pesel
        }
    }

    public class ThisIsASimpleCl
    {
        public static int peselLength = 11; // pole / field

        public string Pesel;

        //??
    }

    public class TextUtils
    {
        Dictionary<int, string> months = new Dictionary<int, string>()
        {
            { 8, "Sierpień" },
            { 1, "Styczeń" },
            { 2, "Luty"},
        };

        int minLength = 8; //01234567
        int maxLength = 25;

        string characters = "zxcvbnmasdfghjklqwertyuiop1234567890!@#$%^&*()ZXCVBNMASDFGHJKLQWERTYUIOP";

        public string GenerateStrongRandomPassword()
        {
            // 48 - 57 ascii 0 - 9 65 - 9* 97 -12*
            string result = string.Empty; // "" null

            //result.Contains

            Random random = new Random();

            int limit = random.Next(minLength, maxLength);

            for (int i = 0; i < limit; i++)
            {
                int position = random.Next(0, characters.Length - 1);

                result += characters[position];
            }

            return result;
        }

        public string PeselToMonth(string pesel)
        {
            string month = pesel.Substring(2, 2);

            int monthNumber = 0;

            int.TryParse(month, out monthNumber);

            return months.ContainsKey(monthNumber) ? months[monthNumber] : string.Empty;
           /* if (monthNumber == 1)
            { 

            }

            switch (monthNumber)
            {
                case 1: 
                    return 
            }*/
            // pesel ? 84080818074
            // 11241411113 // ??

            //08 01 02 12
            //return "Grudzień";

            //return "Sierpień";
        }

    }
}
