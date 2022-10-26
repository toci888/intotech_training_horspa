using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Delegates
{
    public class DelegateExample
    {
        protected int DelegationVictim(int count, int licz)
        {
            return count;
        }

        public int Compute(Func<int, int, int> del)
        {
            return del(0, 1);
        }

        public int Zakrecone()
        {
            return Compute(DelegationVictim);
        }

        List<string> elements = new List<string>() { "kajak", "qualify"};

        public List<string> Manage(Func<string, bool> qualifier) // ????? 
        {
            List<string> result = new List<string>();

            foreach (string element in elements)
            {
                if (qualifier(element))
                {
                    result.Add(element);
                }

            }

            return result;
        }

        public void test() //string el
        {
            List<string> result = Manage(StringUtils.IsPalindrom);

            List<string> second = Manage((el) => el.StartsWith("j"));
        }

        public void CollectionsDemistified()
        {
            List<string> elementsEx = new List<string>() { "kajak", "qualify", "physics" };

            List<string> longOnes = elementsEx.Where((el) => el.Length > 5).ToList();

            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
            {
                { "01", "Styczeń" },
                { "02", "Luty" },
                { "03", "Marzec" },
            };

            List<string> luty = keyValuePairs.
                Where(dict => dict.Key.Contains("2") && dict.Value.Contains("u")).
                Select(m => m.Value).ToList();
        }
    }
}
