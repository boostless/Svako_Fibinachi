using System.Diagnostics;

namespace Fibinachi
{
    internal class Aps
    {
        private double a = 1;
        private double b = 2;
        public double c = 0;
        public double max = 0;

        public Aps(double max)
        {
            this.max = max;

            Stopwatch sw = Stopwatch.StartNew();

            while (c <= max)
            {
                this.c = this.a * this.b;
                this.b = this.a;
                this.a = this.c;
                Console.WriteLine(this.c);
            }

            sw.Stop();
            Console.WriteLine("Laikas: " + sw.ElapsedMilliseconds + "ms");
        }
    }
}
