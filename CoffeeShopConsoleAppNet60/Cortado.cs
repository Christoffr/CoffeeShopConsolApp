using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(int discount, string name) : base(discount, name)
        {
            if (discount > 5)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public int mlMilk()
        {
            return 40;
        }

        public override decimal Price()
        {
            return base.Price() +5 - base.discount;
        }

        public override string Strength()
        {
            return "Medium";
        }


    }
}
