﻿using System;

namespace ElitistFizzBuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var fb = new FizzBuzzes(1, 30000);
            var times = Tester.RecordTimes(fb.functions);

            Console.WriteLine("\n\n\nTEST #: Time Elapsed (ms)");

            for (int i = 0; i < times.Count; i++)
            {
                var t = times[i];
                Console.WriteLine($"TEST {i}: {times[i]}");
            }
        }
    }
}
