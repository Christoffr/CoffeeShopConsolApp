using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee
    {
        public override decimal Price()
        {
            return base.Price() +5;
        }
    }
}
