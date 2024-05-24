using System;

namespace JustLikeACollection
{
    public class Program
    {
        private static void Main()
        {
            Guarda3<string> g3s = new Guarda3<string>()
            {
                "Olá",
                "lalala",
                "Adeus"
            };

            Guarda3<float> g3f = new Guarda3<float>()
            {
                2f,
                54.6f,
                1f
            };

            Console.WriteLine("Strings:");
            foreach (string s in g3s)
            {
                Console.WriteLine($"    {s}");
            }

            Console.WriteLine("Floats:");
            foreach (float f in g3f)
            {
                Console.WriteLine($"    {f}");
            }

            // Expected output:

            // Strings:
            //     Olá
            //     lalala
            //     Adeus
            // Floats:
            //     2
            //     54.6
            //     1
        }
    }
}
