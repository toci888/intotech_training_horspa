using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd
{
    public class GenericTypes//<TKey, TValue>
    {
        public Dictionary<char, int> DivideStringIntoChars(string candidate) // porsche panamera
        {
            Dictionary<char, int> dividedStr = new Dictionary<char, int>();
            //dividedStr.co
            /*foreach (char c in candidate) // p
            {
                if (dividedStr.ContainsKey(c))
                {
                    dividedStr[c]++;
                }
                else
                {
                    dividedStr.Add(c, 1);
                }
            }*/

            for (int i = 0; i < candidate.Length; i++)
            {
                if (dividedStr.ContainsKey(candidate[i]))
                {
                    dividedStr[candidate[i]]++;
                }
                else
                {
                    dividedStr.Add(candidate[i], 1);
                }
            }

            return dividedStr;
        }

        public bool AreAnagrams(string first, string second)
        {
            Dictionary<char, int> firstDict = DivideStringIntoChars(first);

            return firstDict.Compare(DivideStringIntoChars(second));
        }

        public void MyGenericList()
        {
            ///Dictionary<char, int> dividedString = new Dictionary<char, int>();

            Dictionary<string, int> test = new Dictionary<string, int>();

           // 
           

            List<string> namesCollection = new List<string>()
            {
                "Julia", "Tomek", "Robert", "Krzysiu", "Tomek", "Bartek", "Anna"
            };

            namesCollection.Sort();

            List<int> ChromosomePairs = new List<int>()
            {
                8, 4, 2, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,
            };

            ChromosomePairs.Sort();

            int a = 1;
            //foreach (string name in namesCollection)
        }
    }
}
