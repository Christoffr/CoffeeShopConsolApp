using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Order
    {
        private static int _nextID = 0;

        public int OrderID { get; }
        public string? Barista { get; }
        public string? Customer { get; }
        public int TableTakeaway { get; }

        public List<Coffee>? Coffees { get; }

        public Order(string barista, string customer, int tableTakeaway, List<Coffee> coffees)
        {
            OrderID = _nextID;
            _nextID++;

            Barista = barista;
            Customer = customer;
            TableTakeaway = tableTakeaway;

            Coffees = coffees;
        }

        public int Count()
        {
            return Coffees?.Count ?? 0;
        }

        public decimal TotalPrice()
        {
            return Coffees?.Sum(c => c.Price()) ?? 0;
        }

        public int TotalDiscount()
        {
            return Coffees?.Sum(c => c.Discount()) ?? 0;
        }

        public override string ToString()
        {
            return $"Order nr. {OrderID}:\nTotal items: {Count()}\nPrice: {TotalPrice()}\nDiscount: {TotalDiscount()}";
        }

    }
}
