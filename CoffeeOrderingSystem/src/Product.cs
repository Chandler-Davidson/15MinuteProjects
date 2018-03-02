using System;
namespace CoffeeOrderingSystem.src
{
    public class Product
    {
        public readonly string productID;
        public string name;
        public double price;

        public Product(string name, double price)
		{
			productID = BillingSystem.NewID();

			this.name = name;
			this.price = price;
		}
    }
}
