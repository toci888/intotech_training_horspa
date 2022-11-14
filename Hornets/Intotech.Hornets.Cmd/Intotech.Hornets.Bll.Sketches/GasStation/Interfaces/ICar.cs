using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.GasStation.Interfaces
{
    public interface ICar<TGasolines> where TGasolines : IGasoline
    {
        string[] GetFuel();
    }
}
