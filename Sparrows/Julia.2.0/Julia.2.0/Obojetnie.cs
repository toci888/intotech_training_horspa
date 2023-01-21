using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julia._2._0
{
    public static class Obojetnie
    {
        private static ITest test;

        public static void Swap(int a, int b)
        {
            int swap = a;
            a = b;
            b = swap;
        }

        public static void SwapIfGreater(int a, int b)
        {
            int swap = a;

            if (a > b)
            {
                a = b;
                b = swap;
            }
        }

        public static Entity[] GetEntities(int count)
        {
            Entity[] entities = new Entity[count];

            return null;
        }
    }
}
