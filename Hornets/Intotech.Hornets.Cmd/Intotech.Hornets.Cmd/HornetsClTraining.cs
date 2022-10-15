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
            string result = string.Empty; // "" null
            Console.WriteLine("Podaj długość hasła: ");
            int end = Int16.Parse(Console.ReadLine());
            Random random = new Random();
            if(end > minLength)
            {
                for (int i = 0; i < end; i++)
                {
                    int position = random.Next(0, characters.Length - 1);

                    result += characters[position];
                }
            } else
            {
                Console.WriteLine("Hasło za krótkie, musi mieć min 8 znaków!");
            }



            return result;
        }
    }
}
