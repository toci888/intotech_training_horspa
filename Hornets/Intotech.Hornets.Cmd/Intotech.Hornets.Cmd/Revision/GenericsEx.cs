using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Revision
{
    public interface ICovarianceClient<T>
    {

    }

    public class CovarianceClient<T> : ICovarianceClient<T>
    {

    }
    public class GenericBase
    {
        // public CovarianceClient<GenericBase> field = 
        //    new CovarianceClient<GenericsEx>();
    }
    public class GenericsEx : GenericBase
    {
        public ICar<Engine> car = new Car<Diesel>();
        List<GenericBase> asa = new List<GenericBase>()
        {
            new GenericsEx()
        };
    }

    public interface ICar<out TEngine>
    {

    }

    public class Car<TEngine> : ICar<TEngine>
    {

    }

    public abstract class Engine
    {
        
    }

    public class Diesel : Engine
    {
        
    }
}
