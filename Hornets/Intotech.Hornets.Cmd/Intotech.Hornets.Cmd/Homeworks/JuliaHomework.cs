using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intotech.Hornets.Cmd.Homeworks
{
    public class JuliaHomework
    {
        protected Entity[] _entities = new Entity[] { 
            new Entity() { Id = 1, Name = "Julia" } ,
            new Entity() { Id = 2, Name = "Kacper" }
        };
    }

    // wyciaga ludki o nieparzystych id

    // wyciaga kobiety

    // sortuje po name od konca

    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
