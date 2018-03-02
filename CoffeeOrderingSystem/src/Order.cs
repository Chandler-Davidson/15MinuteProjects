using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeOrderingSystem.src
{
    public class Order
    {
        public readonly string orderID;
        public Dictionary<Product, int> productQuantity; // Represents the product and the quntity

        public bool open;
		public double Total => productQuantity.Sum(x => x.Key.price * x.Value);

        public Order()
        {
            orderID = BillingSystem.NewID();
            productQuantity = new Dictionary<Product, int>();
            open = true;
        }

        public void AddToOrder(Product p1)
        {
            if (productQuantity.ContainsKey(p1))
                productQuantity[p1]++;
            else
                productQuantity.Add(p1, 1);
        }

        public void AddToOrder(Dictionary<Product, int> productList)
        {
            foreach (var item in productList)
            {
                if (productQuantity.Contains(item))
                    productQuantity[item.Key] += productList[item.Key];
                else
                    productQuantity.Add(item.Key, item.Value);
            }

        }


    }
}
