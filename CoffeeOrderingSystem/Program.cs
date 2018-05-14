using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeOrderingSystem.src;

namespace CoffeeOrderingSystem
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var cust = new Customer("Chandler", "Davidson");

			var order1 = new Order();
			var l = new Dictionary<Product, int>()
			{
				{ new Product("coffee", 2.50), 3 },
				{ new Product("espresso", 3.00), 1 }
			};
			order1.AddToOrder(l);

			cust.AddOrder(order1);

			foreach (var order in cust.Orders)
			{
				foreach (var productQuantityPair in order.productQuantity)
				{
					var product = productQuantityPair.Key;
					var quantity = productQuantityPair.Value;

					Console.WriteLine($"{product.name}: ${product.price}\tX{quantity}");
				}

				Console.WriteLine("==========\nTotal: " + order.Total);
			}
		}
	}
}
