﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.TankStation.Interfaces
{
    public interface IDistributor<TGasolines> where TGasolines : IEnumerable<IGasoline>
    {
    }
}
