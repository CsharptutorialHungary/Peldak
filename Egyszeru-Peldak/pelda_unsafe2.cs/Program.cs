using System;

namespace pelda_unsafe2
{
    class Program
    {
        private static unsafe void Fibonaccci()
        {
            const int meddig = 40;
            int* fib = stackalloc int[meddig];
            int* p = fib; //a mutató így fib[0] elemet mutatja
            *p++ = *p++ = 1; //első két elem 1-esre állítása
            for (int i = 2; i < meddig; ++i, ++p)
            {
                *p = p[-1] + p[-2];
                Console.WriteLine(fib[i]);
            }
        }

        static void Main(string[] args)
        {
            Fibonaccci();
            Console.ReadKey();
        }
    }
}
