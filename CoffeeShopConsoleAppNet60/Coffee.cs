using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        protected int discount;

        protected Coffee(int discount)
        {
            this.discount = discount;
        }

        public virtual decimal Price()
        {
            return 20;
        }

        public abstract string Strength();

    }
}
