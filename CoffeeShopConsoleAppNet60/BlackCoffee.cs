using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount) : base(discount)
        {
            if (discount > 5)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override decimal Price()
        {
            return base.Price() - base.discount;
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
