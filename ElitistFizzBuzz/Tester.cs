using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ElitistFizzBuzz
{
    public static class Tester
    {
        public delegate void testFunc();

        public static List<long> RecordTimes(List<testFunc> functions)
        {
            var stopwatch = new Stopwatch();
            var results = new List<long>();

            foreach (var func in functions)
            {
                Console.WriteLine("***STARTING " + func.ToString() + "***");

                stopwatch.Start();
                func();
                stopwatch.Stop();

                results.Add(stopwatch.ElapsedMilliseconds);
                stopwatch.Reset();
            }

            return results;
        }
    }
}
