using System;
namespace CoffeeOrderingSystem.src
{
    public class Product
    {
        public readonly string productID;
        public string name;
        public double price;
        public int quantity;
        public double Total => price * quantity;

		public Product(string name, double price)
		{
			productID = BillingSystem.NewID();

			this.name = name;
			this.price = price;
		}
    }
}
