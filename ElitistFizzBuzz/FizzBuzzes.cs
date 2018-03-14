﻿using System;
using System.Collections.Generic;

namespace ElitistFizzBuzz
{
	public class FizzBuzzes
	{
		int min, max;

		public List<Tester.testFunc> functions;

		public FizzBuzzes(int min, int max)
		{
			this.min = min;
			this.max = max;

			functions = new List<Tester.testFunc>
			{
				FizzBuzz0,
				FizzBuzz1,
				FizzBuzz2,
				FizzBuzz3,
				FizzBuzz4,
				FizzBuzz5,
				FizzBuzz6
			};
		}

		// Solution 0:
		//  Check and check again
		private void FizzBuzz0()
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
		private void FizzBuzz1()
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
		// Thanks to https://github.com/jeffsheets for this horrible mess...
		private void FizzBuzz2()
		{
			int i = max;

			do
			{
				if (Array.BinarySearch(new int[] { 15, 30, 45, 60, 75, 90 }, i) >= 0)
					Console.WriteLine("FizzBuzz");
				else if ((100 - i) % 3 == 0)
					Console.WriteLine("Buzz");
				else if ((100 - i) / 5 == (100 - i) / 5.0)
					Console.WriteLine("Fizz");
				else
					Console.WriteLine(max + 1 - i);
			} while (--i >= min);
		}

		// Solution 3:
		//  Counting for the sake of counting
		private void FizzBuzz3()
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
		private void FizzBuzz4()
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
		private void FizzBuzz5()
		{
			for (int i = min; i <= max; i++)
			{
				if (i % 5 == 0 && i % 3 == 0)
					Console.WriteLine("FizzBuzz");
				else if (i % 3 == 0)
					Console.WriteLine("Fizz");
				else if (i % 5 == 0)
					Console.WriteLine("Buzz");
				else
					Console.WriteLine(i);
			}
		}

		// Solution 6:
		//  String output
		private void FizzBuzz6()
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
