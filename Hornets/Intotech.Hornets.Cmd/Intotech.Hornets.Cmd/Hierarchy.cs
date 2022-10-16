using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd
{
    public abstract class Hierarchy // 
    {
        protected int Degree;

        public virtual bool Advance()
        {
            Degree++;

            return true;
        }

        public abstract string TellName();
    }

    public class Soldier : Hierarchy
    {
        public override string TellName()
        {
            return "Soldier";
        }
    }

    public class Colonel : Soldier
    {
        public override string TellName()
        {
            return "Colonel";
        }
    }

    public sealed class General : Soldier
    {
        public override bool Advance()
        {
            return true;
        }
    }

}
