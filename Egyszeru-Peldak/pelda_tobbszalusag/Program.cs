using System;
using System.Threading;

namespace pelda_tobbszalusag
{
    class Program
    {
        private static int a;

        static void Main(string[] args)
        {
            a = 2;
            Console.WriteLine($"a értéke: {a}");
            Interlocked.Increment(ref a);
            Console.WriteLine($"a értéke: {a}");
        }
    }
}
