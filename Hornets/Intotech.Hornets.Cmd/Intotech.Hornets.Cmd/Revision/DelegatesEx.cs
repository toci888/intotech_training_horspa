using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Revision
{
    public class DelegatesEx
    {
        public int[] elements = new int[] { 9,4,3,5,2,3,6,1 };
        Func<int> ReturnDel = () => 8;
        Func<int, int> OneParamDel = (i) => i * 2;

        public int[] Filter(int min)
        {
            int[] res = elements.Where(x => x >= min).ToArray();

            int[] result = new int[8];
            int i = 0;
            foreach (int el in elements)
            {
                if (el >= min)
                {
                    result[i++] = el;
                }
            }

            return result;
        }

        public void Whatever()
        {                //8              2 * 2
            int doopa = ReturnDel() + OneParamDel(2);

            string koopa = "lalala";

            koopa.Where((ch) => ch == 'a');
        }

        public bool test(char ch)
        {
            return ch == 'a';
        }

        private int ReturnDelPrv()
        {
            return 8;
        }
    }
}
