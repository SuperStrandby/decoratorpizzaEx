using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternPizza
{
    abstract class PizzaDecorator : IPizzaComponent
    {
        public PizzaDecorator(IPizzaComponent pizza)
        {
            _pizza = pizza;
        }

        protected IPizzaComponent _pizza;
        public abstract int BeregnPris();
    }
}
