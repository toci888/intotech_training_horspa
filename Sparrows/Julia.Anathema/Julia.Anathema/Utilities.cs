using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julia.Anathema
{
    public static class Utilities
    {
        // aeiqwrioa

        //eraxitujokesac
        //juli => 1

        // string samog = "aeuio";
        //string spol = "qwrtplk"

        // samog spol
        // for (i < x? i++)
        // samo i % 2 ==0 
        // spol i % 2 == 1

        // julia => false
        // alikoju => true

        public const int Limit = 25;

        public static Functionalities[] GetFunctionalitiesList(int min = 5)
        {
            Functionalities[] functionalities = new Functionalities[Limit];

            Functionalities f = new Functionalities();

            f.AddEntity(new CatEntity() { Id = 4, Kind = 2 });



            return functionalities;
        }
    }
}
