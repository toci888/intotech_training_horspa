using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Bll.Sketches.GasStation.Interfaces
{
    public interface IStore<TGoods, TGasolines>
        where TGoods : IGoods
        where TGasolines : IGasoline
    {
        double Price { get; set; }

        string[] Type { get; set; }
        string GetPurchase();

        bool AddPurchase(IGasoline gasoline, TGoods goods);
    }
}
