using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Revision
{
    public class LinqEx
    {
        string[] elements = new string[] { "ala", "john", "whatever" };

        public string[] Elements()
        {
            return elements.Where(str => str.Contains("a")).ToArray();
        }
    }
}
