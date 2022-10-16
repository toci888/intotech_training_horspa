using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Interfaces
{
    public interface ICar
    {
        protected int Dupa { get; set; }

        private void Test()
        {
            Dupa++;
        }
    }
}
