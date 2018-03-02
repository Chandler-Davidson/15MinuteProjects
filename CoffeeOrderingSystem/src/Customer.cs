using System;
using System.Collections.Generic;

namespace CoffeeOrderingSystem.src
{
    public class Customer
    {
        public readonly string userID;
		public string firstName;
        public string lastName;
        public List<Order> Orders { get; private set; }
        public float openBill { get; private set; }

        public Customer(string f, string l)
        {
            userID = BillingSystem.NewCustomerID();
            this.firstName = f;
            this.lastName = l;
            Orders = new List<Order>();
        }


    }
}
