using System;
using System.Collections.Generic;

namespace TheyCameBefore
{
    public class Program
    {
        private static void Main()
        {
            IEnumerable<int> someInts = new List<int>()
            {
                10, 20, -83, -11, 0, 1, 17, -9, -3, 52
            };
            IEnumerable<double> someDoubles = new List<double>() {
                1.4, -8.9, 3.11, 0.04, 8.33, -6.3, -0.003, Math.PI, Math.E
            };

            foreach (int i in BeforeUtils.GetTheOnesBefore(someInts, 5))
            {
                Console.Write($"{i,8} ");
            }

            Console.WriteLine();

            foreach (double d in BeforeUtils.GetTheOnesBefore(someDoubles, 0.0001))
            {
                Console.Write($"{d,8:f3} ");
            }

            Console.WriteLine();

            // Expected result:
            //      -83      -11        0        1       -9       -3
            //   -8.900   -6.300   -0.003
        }
    }
}
