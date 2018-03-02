using System;
using System.Collections.Generic;

namespace CoffeeOrderingSystem.src
{
    public static class BillingSystem
    {
        public static HashSet<string> customerIDs = new HashSet<string>();
        private static Random random = new Random();

        public static string NewID()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            // Generate random string until a new one is found
            for (int i = 0; i < Int32.MaxValue; i++) // Time out just in case
            {
                string id = "";

                for (int j = 0; j < 8; j++)
                    id += chars[random.Next(chars.Length)];

                if (!customerIDs.Contains(id))
                    return id;
            }

            return null;
        }
    }
}
