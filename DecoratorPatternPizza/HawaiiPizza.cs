using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternPizza
{
    class HawaiiPizza : IPizzaComponent
    {
        public int BeregnPris()
        {
            return 40;
        }

        public override string ToString()
        {
            return "En lækker HawaiiPizza m Ananas og jaka-bov";
        }
    }
}
