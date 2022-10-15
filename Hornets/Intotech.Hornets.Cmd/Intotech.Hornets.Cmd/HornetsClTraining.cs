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
        int minLength = 8; //01234567
        string characters = "zxcvbnmasdfghjklqwertyuiop1234567890!@#$%^&*()ZXCVBNMASDFGHJKLQWERTYUIOP";

        public string GenerateStrongRandomPassword()
        {
            // 48 - 57 ascii 0 - 9 65 - 9* 97 -12*
            string result = string.Empty; // "" null

            Random random = new Random();

            for (int i = 0; i < minLength; i++)
            {
                int position = random.Next(0, characters.Length - 1);

                result += characters[position];
            }

            return result;
        }
    }
}
