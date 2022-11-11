using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Delegates
{
    public class SearchResultEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }

    }
    public class RobDelegates
    {
        Dictionary<string, Func<SearchResultEntity, string, string>> monthsMap = 
            new Dictionary<string, Func<SearchResultEntity, string, string>>()
            {
                { "Name", (sre, str) => sre.Name = str }, // creditsafe
                { "Description", (sre, str) => sre.Description = str },
            };
       // List<Tuple<string, string>> 


        Func<int, int> Sd = SendDigit;
        Func<int, int> SdAn = (i) => i * 3;

        private static int SendDigit(int i)
        {
            return i * 3;
        }

        public void doopa()
        {
            Sd(2);
        }
    }
}
