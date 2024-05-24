using System;

namespace MyEnumerable
{
    public class Program
    {
        private static void Main()
        {
            Guarda3<string> g3s = new Guarda3<string>();
            Guarda3<float> g3f = new Guarda3<float>();

            g3s.SetItem(0, "Olá");
            g3s.SetItem(2, "Adeus");

            g3f.SetItem(2, 54.6f);

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

            // Expected output

            // Strings:
            //     Olá
            //
            //     Adeus
            // Floats:
            //     0
            //     0
            //     54.6
        }
    }
}
