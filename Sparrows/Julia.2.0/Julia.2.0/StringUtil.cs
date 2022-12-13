using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julia._2._0
{
    public static class StringUtil
    {
        private static string Consonants = "qwrtpsdfghjklzxcvbnm";
        private static string Vowels = "euioya";

        public static string GetMixedString(int doopa) // 2 c  2 v , 2 c  2 v
        {
            //awesik
            string result = string.Empty;
            Random rnd = new Random();

            for (int i = 0; i < doopa; i++)
            {
                if (i % 2 == 1)
                {
                    result += Consonants[rnd.Next(0, Consonants.Length - 1)]; // rnd 0 dl consonants
                }
                else
                {
                    result += Vowels[rnd.Next(0, Vowels.Length - 1)];
                }
            }

            return result;
        }
    }
}
