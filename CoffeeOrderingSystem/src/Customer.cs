using System;
using System.Collections.Generic;

namespace CoffeeOrderingSystem.src
{
	public class Customer
	{
		public readonly string userID;
		public string firstName;
		public string lastName;
		public float openBillTotal { get; private set; }

		// Classes can read, but can't modify
		private List<Order> _orders;
		public IReadOnlyCollection<Order> Orders { get; private set; }

		public Customer(string f, string l)
		{
			userID = BillingSystem.NewID();
			this.firstName = f;
			this.lastName = l;

			_orders = new List<Order>();
			Orders = _orders.AsReadOnly();
		}

		public void AddOrder(Order order)
		{
			_orders.Add(order);
		}

	}
}
