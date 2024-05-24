using System;

namespace MyGenericClass
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
            Console.WriteLine($"    {g3s.GetItem(0)}");
            Console.WriteLine($"    {g3s.GetItem(1)}");
            Console.WriteLine($"    {g3s.GetItem(2)}");

            Console.WriteLine("Floats:");
            Console.WriteLine($"    {g3f.GetItem(0)}");
            Console.WriteLine($"    {g3f.GetItem(1)}");
            Console.WriteLine($"    {g3f.GetItem(2)}");

            // Expected output:

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
