using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public string Name { get; protected set; }

        protected int discount;

        protected Coffee(int discount, string name)
        {
            this.discount = discount;
            Name = name;
        }

        public virtual decimal Price()
        {
            return 20;
        }

        public abstract string Strength();

    }
}
