using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julia.Anathema
{
    public class Functionalities
    {
        protected List<Entity> Entities = new List<Entity>();

        public bool AddEntity(Entity element)
        {
            Entities.Add(element);

            //element.IsIdEven = element.Id % 2 == 0;
            element.Name = "Leopold";

            return true;
        }
    }
}
