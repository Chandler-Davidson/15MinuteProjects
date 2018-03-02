using System;
using System.Collections.Generic;

namespace CoffeeOrderingSystem.src
{
    public static class BillingSystem
    {
        public static HashSet<string> customerIDs = new HashSet<string>();
        private static Random random = new Random();

        public static string NewCustomerID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Generate random string until a new one is found
            while (true)
            {
                string id = "";

                for (int i = 0; i < 8; i++)
                    id += chars[random.Next(chars.Length)];

                if (!customerIDs.Contains(id))
                    return id;
            }

            return null;
        }
    }
}
