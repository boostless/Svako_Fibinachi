using System;
using System.Diagnostics;

namespace Fibinachi
{
    class Program
    {
        static void Aps()
        {
            double a = 1;
            double b = 2;
            double c = 0;
            double max = Math.Pow(10, 15);

            Stopwatch sw = Stopwatch.StartNew();

            while (c <= max)
            {
                c = a * b;
                b = a;
                a = c;
                Console.WriteLine(c);
            }

            sw.Stop();
            Console.WriteLine("Laikas: " + sw.ElapsedMilliseconds + "ms");
        }

        static void Main(string[] args)
        {
            Aps();
        }
    }
}