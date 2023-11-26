using System;
using System.Diagnostics;

namespace Fibinachi
{
    class Program
    {

        static void Main(string[] args)
        {
            Aps fib = new Aps(Math.Pow(10, 20));
            Console.WriteLine(fib.c);
        }
    }
}