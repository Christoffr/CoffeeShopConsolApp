using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{

    public enum Blend
    {
        Keini,
        Reshad,
        Espresso,
        Daterra,
        FamiliaLizaraso,
        Basha
    }


    public abstract class Coffee
    {
        protected int discount;
     
        public string Name { get; protected set; }
        public Blend Blend { get; protected set; }

        protected Coffee(int discount, string name, Blend blend)
        {
            this.discount = discount;
            Name = name;
            Blend = blend;
        }

        public virtual decimal Price()
        {
            return 20;
        }

        public int Discount()
        {
            return discount;
        }

        public abstract string Strength();

    }
}
