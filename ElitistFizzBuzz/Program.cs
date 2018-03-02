using System;

namespace ElitistFizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var foo = new FizzBuzzes();
            var results = foo.recordTimes(1, 3000); // Range of numbers

            Console.WriteLine("\n\n\n\n\n");

            for (int i = 0; i < results.Count; i++)
				Console.WriteLine("TEST {0}: {1}", i, results[i]);
        }
    }
}
