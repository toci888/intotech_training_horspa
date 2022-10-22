using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd
{
    public static class StringUtils
    {
        public static int ExtractDigitsForString(string candidate)
        {
            string effect = string.Empty;

            foreach (char c in candidate)
            {
                if (c == '0')
                {
                    effect += "0";
                }
                else
                {
                    int res = 0;
                    int.TryParse(c.ToString(), out res);

                    if (res != 0)
                    {
                        effect += c;
                    }
                }
            }

            int result = 0;
            int.TryParse(effect, out result);

            return result;
        }

        // 012345
        // bartek -> ketrab 
        public static string ReverseString(string candidate)
        {
            string result = string.Empty; // -> "" null 

            //? candidate -> result
            for (int i = candidate.Length - 1; i > -1; i--)
            {
                // ? 
                result += candidate[i];
            }

            return result;
        }

        //kajak -> kajak
        public static bool IsPalindrom(string candidate)
        {

            return ReverseString(candidate) == candidate;
        }
    }
}
