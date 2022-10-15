using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd
{
    public class GhostRider
    {
        Dictionary<string, GhostRider> test = new Dictionary<string, GhostRider>();

        Dictionary<char, string> digitToTxtMap = new Dictionary<char, string>()
        {
            { '8', "eight" },
            { '4', "four"},
            { '0', "zero"}
        };

        public string ConvertNumberToText(string number)
        {
            string result = string.Empty;

            for (int i = 0; i < number.Length; i++)
            {                                 //8, 4
                if (digitToTxtMap.ContainsKey(number[i]))
                {
                    result += digitToTxtMap[number[i]];
                }
            }

            return result;

            foreach (KeyValuePair<char, string> item in digitToTxtMap)
            {
                //item.
            }
        }
        // "840808" -> osiem cztery zero
    }
}
