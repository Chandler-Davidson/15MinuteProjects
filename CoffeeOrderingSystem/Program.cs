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
            var con = DBConnection.Instance;

            var cust = new Customer("Chandler", "Davidson");
            Console.WriteLine(cust.firstName + " " + cust.lastName + "\nID: " + cust.userID);

            var coffee = new Product("Coffee", 2.50);
            var espresso = new Product("Espresso", 3.00);

            var order1 = new Order();
            var l = new List<Product>() { coffee, espresso };

            //order1.AddToOrder(new List<Product>(){ coffee, espresso });

            Console.WriteLine(order1.Total);

            double total => l.Sum(x => x.Total);

            Console.WriteLine(total);
        }
    }
}
