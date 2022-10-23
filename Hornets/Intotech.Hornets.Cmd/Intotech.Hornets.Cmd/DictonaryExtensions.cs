using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd
{
    public static class DictonaryExtensions
    {
        public static bool Compare(this Dictionary<char, int> subject, Dictionary<char, int> second)
        {
            if (subject.Count != second.Count)
            {
                return false;
            }

            foreach (KeyValuePair<char, int> element in subject)
            {
                if (second.ContainsKey(element.Key))
                {
                    // c sub 5, sec 3
                    if (subject[element.Key] != second[element.Key])
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
