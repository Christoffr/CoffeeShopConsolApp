using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class OrderSystem
    {
        private List<Order> Orders { get; set; }

        public OrderSystem()
        {
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public Order? GetOrder(int orderId)
        {
            return Orders.FirstOrDefault(o => o.OrderID == orderId);
        }

        public void RemoveOrder(int orderId)
        {
            Order? order = GetOrder(orderId);

            if (order != null)
            {
                Orders.Remove(order);
            }
        }

        public int GetTotalOrders()
        {
            return Orders.Count;
        }

        public decimal GetTotalRevenue()
        {
            return Orders.Sum(o => o.TotalPrice());
        }

        public decimal GetTotalDiscount()
        {
            return Orders.Sum(o => o.TotalDiscount());
        }

        public List<Order> GetOrdersByCustomer(string customerName)
        {
            return Orders
                .Where(o => o.Customer == customerName)
                .ToList();
        }
    }
}
