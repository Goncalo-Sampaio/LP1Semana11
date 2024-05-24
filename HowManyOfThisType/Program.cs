using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    public class Program
    {
        private const double x = 1.23;

        private static void Main()
        {
            Random rng = new Random();
            ICollection<object> items = new List<object>();

            items.Add(1);                    // int
            items.Add(1.3);                  // double
            items.Add(-0.5f);                // float
            items.Add("hello");              // string
            items.Add(true);                 // bool
            items.Add(false);                // bool
            items.Add(rng.NextDouble() > x); // bool
            items.Add(Math.PI);              // double
            items.Add(Math.E);               // double
            items.Add(rng.NextDouble());     // double
            items.Add(rng.Next());           // int

            Console.WriteLine($"int   : {Checker.HowManyOfType<int>(items)}");
            Console.WriteLine($"float : {Checker.HowManyOfType<float>(items)}");
            Console.WriteLine($"double: {Checker.HowManyOfType<double>(items)}");
            Console.WriteLine($"bool  : {Checker.HowManyOfType<bool>(items)}");
            Console.WriteLine($"string: {Checker.HowManyOfType<string>(items)}");
            Console.WriteLine($"byte  : {Checker.HowManyOfType<byte>(items)}");

            // Expected output
            // int   : 2
            // float : 1
            // double: 4
            // bool  : 3
            // string: 1
            // byte  : 0
        }
    }
}
