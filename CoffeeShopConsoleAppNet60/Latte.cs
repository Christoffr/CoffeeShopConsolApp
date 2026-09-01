using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public int mlMilk()
        {
            return 400;
        }

        public override decimal Price()
        {
            return base.Price() + 20;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
