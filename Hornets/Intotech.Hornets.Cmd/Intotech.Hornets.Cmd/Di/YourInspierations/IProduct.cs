using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Di.YourInspierations
{
    public interface IProduct
    {
        double Price(double i = 0);
        string Name();
        string Description();
        string Picture();
    }
}
