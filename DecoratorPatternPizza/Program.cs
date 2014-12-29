using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            HawaiiPizza hawaii = new HawaiiPizza();
            ExtraOst extraOst = new ExtraOst(hawaii);
            ExtraOst extraeExtraOst = new ExtraOst(extraOst);

            Console.WriteLine(extraeExtraOst);
            Console.WriteLine(extraeExtraOst.BeregnPris());
        }
    }
}
