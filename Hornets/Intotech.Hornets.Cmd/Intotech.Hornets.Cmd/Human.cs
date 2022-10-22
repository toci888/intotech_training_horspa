using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd
{
    public abstract class Human
    {
        public int Gender { get; protected set; }

        protected int[] ChromosomePairs = new int[23];

        public abstract Human HaveSex(Human h);
        //ambiguous
       // public abstract Human[] HaveSex(Human h);

        public abstract Human[] HaveSex(Human[] h1); // orgia

        protected virtual Human Sex(Human h)
        {
            int dupa = h.ChromosomePairs[0] | ChromosomePairs[0]; //??

            return h;
        }
    }

    public class Woman : Human
    {
        public override Human HaveSex(Human h)
        {
            //??
            //HaveSex();
            return new Woman();
        }

        public override Human[] HaveSex(Human[] h1)
        {
            //Convert.ToInt16();
            //HaveSex();
            return new Woman[2];
        }
    }



    public class NotNecessary
    {
        protected Human Human;

        public void Idk()
        {
            //Human.Gender = 1;
            //Human.)
        }
    }

    public class AccessModifiers
    {
        private string UnderivedUnavaialbleInObjApi = "UnderivedUnavaialbleInObjApi";
        protected string DerivedUnavailableInObjApi = "DerivedUnavailableInObjApi";
        internal string AvailableInObjApiOfSameAssembly = "AvailableInObjApiOfSameAssembly";
        public string AvailableEverywhere = "AvailableEverywhere";

        public void SetUnderivedUnavaialbleInObjApi(string element)
        {
            UnderivedUnavaialbleInObjApi = element;
        }

        public virtual void TestVariablesForTheirAccess(AccessModifiers am)
        {
            //this.UnderivedUnavaialbleInObjApi
            //am.UnderivedUnavaialbleInObjApi
        }
    }

    public class AmTester : AccessModifiers
    {
        public void Test()
        {
            string what = DerivedUnavailableInObjApi;
            AccessModifiers amod = new AccessModifiers();
            AccessModifiers amodSecond = new AccessModifiers();
            //amod.UnderivedUnavaialbleInObjApi;
            amod.SetUnderivedUnavaialbleInObjApi("fuqe9qeguf9qeghqu9qr9");
        }
    }
}
