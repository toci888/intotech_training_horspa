using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Revision
{
    public abstract class Vehicle : IVehicle
    {
        public abstract bool SpeedUp(int progress);
    }

    public interface IVehicle
    {
        bool SpeedUp(int progress);
    }

    public class Mazda : Vehicle
    {
        public override bool SpeedUp(int progress)
        {
            throw new NotImplementedException();
        }
    }

    public class Nissan : Vehicle
    {
        public override bool SpeedUp(int progress)
        {
            throw new NotImplementedException();
        }
    }

    public class Race
    {
        public void Ride(IVehicle vehicle)
        {
            vehicle.SpeedUp(2);
        }
    }
}
