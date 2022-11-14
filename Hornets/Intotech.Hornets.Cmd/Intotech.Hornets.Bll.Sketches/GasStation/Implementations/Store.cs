using Intotech.Hornets.Bll.Sketches.GasStation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.GasStation.Implementations
{
    public class Store : IStore<IGoods, IGasoline>
    {
        public double Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string[] Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool AddPurchase(IGasoline gasoline, IGoods goods)
        {
            throw new NotImplementedException();
        }

        public string GetPurchase()
        {
            throw new NotImplementedException();
        }
    }
}