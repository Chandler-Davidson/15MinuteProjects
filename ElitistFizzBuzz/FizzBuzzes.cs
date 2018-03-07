using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ElitistFizzBuzz
{
    public class FizzBuzzes
    {
        // Declare List of function delegates
		private delegate void FizzBuzzFunc(int a, int b);
        List<FizzBuzzFunc> functions;

		public FizzBuzzes()
        {
            // Init List
            functions = new List<FizzBuzzFunc>
            {
                FizzBuzz0,
                FizzBuzz1,
                //FizzBuzz2,
                FizzBuzz3,
                FizzBuzz4,
                FizzBuzz5,
                FizzBuzz6
            };
        }

        // Runs through each test from min to max
        // output a List of TimeSpan of elapsed time
        public List<TimeSpan> recordTimes(int min, int max) 
        {
            var stopwatch = new Stopwatch();
            var results = new List<TimeSpan>();

            foreach (var func in functions)
			{
                Console.WriteLine("***STARTING " + func.ToString() + "***");

                stopwatch.Start();
                func(min, max);
                stopwatch.Stop();

                results.Add(stopwatch.Elapsed);
                stopwatch.Reset();
			}

            return results;
        }

        // Solution 0:
        //  Check and check again
        private void FizzBuzz0(int min, int max)
		{
			for (int i = min; i <= max; i++)
			{
				if (i % 3 == 0)
					Console.Write("Fizz");

				if (i % 5 == 0)
					Console.Write("Buzz");

				if (i % 3 != 0 && i % 5 != 0)
					Console.Write(i);

				Console.WriteLine();
			}
		}

        // Solution 1:
        //  Compute once, check twice
        private void FizzBuzz1(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                int a = i % 3;
                int b = i % 5;

                if (a == 0)
                    Console.Write("Fizz");
                if (b == 0)
                    Console.Write("Buzz");
                if (a != 0 && b != 0)
                    Console.Write(i);
                
                Console.WriteLine();
            }
        }

        // Solution 2:
        // Over engineered with lookup
        private void FizzBuzz2(int min, int max)
        {
            var table = new Dictionary<int, string>();
            // Maybe not...

        }

        // Solution 3:
        //  Counting for the sake of counting
        private void FizzBuzz3(int min, int max)
        {
            int a = 1;
            int b = 1;

            for (int i = min; i <= max; i++)
            {
                if (a == 3) 
                {
                    Console.Write("Fizz");
                    a = 0;
                }

                if (b == 5)
                {
                    Console.Write("Buzz");
                    b = 0;
                }

                if (a != 3 && b != 5)
                    Console.Write(i);

                a++;
                b++;

                Console.WriteLine();
            }
        }

        // Solution 4:
        //  Compute, Compute, and Compute
        private void FizzBuzz4(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
                if (i % (3 * 5) == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }

        // Solution 5:
        //  Check and check, but without checks
        private void FizzBuzz5(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
				if (i % 5 == 0 && i % 3 == 0)
                    Console.WriteLine("FizzBuzz");
				else if (i % 3 == 0)
					Console.WriteLine ("Fizz");
				else if (i % 5 == 0)
					Console.WriteLine("Buzz");
				else
					Console.WriteLine(i);
            }
        }

        // Solution 6:
        //  String output
        private void FizzBuzz6(int min, int max)
        {
            for (int i = min; i <= max; i++)
            {
				var output = "";
				if (i % 3 == 0)
					output += "Fizz";
				if (i % 5 == 0)
					output += "Buzz";
				if (output == "")
					output += i;
                Console.WriteLine(output);
            }
        }
    }
}