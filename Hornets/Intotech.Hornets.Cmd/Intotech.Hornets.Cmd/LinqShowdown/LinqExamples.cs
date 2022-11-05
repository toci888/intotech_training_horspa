using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.LinqShowdown
{
    public class LinqExamples
    {
        string whatever = "wheelo is cool";

        public void TestLinq()
        {
            whatever.Where(m => m == 'o');
           // whatever.ToDictionary()

            foreach (var item in whatever)
            {
                if (item == 'o')
                {
                   // yield return item;
                }
            }
        }
    }
}
