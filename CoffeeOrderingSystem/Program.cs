using System;
using CoffeeOrderingSystem.src;

namespace CoffeeOrderingSystem
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var con = DBConnection.Instance;
            con.Open();

            var cust = new Customer("Chandler", "Davidson");
        }
    }
}
