using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMilk
    {
        public Cortado(int discount, string name, Blend blend, MilkType milk) : base(discount, name, blend)
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
