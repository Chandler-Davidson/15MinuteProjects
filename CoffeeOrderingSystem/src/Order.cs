using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeOrderingSystem.src
{
    public class Order
    {
        public readonly string orderID;
        List<Product> items;
        public bool open;
		public double Total => items.Sum(x => x.Total);

        public Order()
        {
            orderID = BillingSystem.NewID();
            items = new List<Product>();
            open = true;
        }

        public void AddToOrder(Product p1)
        {
            items.Add(p1);
        }

        public void AddToOrder(List<Product> p)
        {
            items.AddRange(p);
        }


    }
}
