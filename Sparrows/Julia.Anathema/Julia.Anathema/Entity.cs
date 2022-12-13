using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julia.Anathema
{
    public class Entity
    {
        public int Id { get; set; }

        public bool IsIdEven { get { return Id % 2 == 0; } }

        public string Name { get; set; }

        public string FirstName { get { return Name; } }
    }
}
