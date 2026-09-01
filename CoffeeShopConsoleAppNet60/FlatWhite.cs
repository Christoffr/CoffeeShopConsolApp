using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class FlatWhite : Coffee, IMilk
    {
        public FlatWhite(int discount, string name) : base(discount, name)
        {
            if (discount > 5)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public int mlMilk()
        {
            return 300;
        }

        public override decimal Price()
        {
            return base.Price() + 15 - base.discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
