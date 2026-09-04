using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMilk
    {
        public Latte(int discount, string name, Blend blend, MilkType milk) : base(discount, name, blend)
        {
            if (discount > 5)
            {
                throw new ArgumentOutOfRangeException();
            }

            Milk = milk;
        }

        public MilkType Milk { get; set; }

        public int mlMilk()
        {
            return 400;
        }

        public override decimal Price()
        {
            return base.Price() + 20 -base.discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
