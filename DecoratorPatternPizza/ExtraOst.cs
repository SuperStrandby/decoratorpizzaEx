using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternPizza
{
    class ExtraOst : PizzaDecorator
    {
        public ExtraOst(IPizzaComponent pizza) : base(pizza)
        {
        }

        public override int BeregnPris()
        {
            return _pizza.BeregnPris() + 5;
        }

        public override string ToString()
        {
            return _pizza + ", Med extra ost";
        }
    }
}
