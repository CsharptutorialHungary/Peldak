using System;

namespace pelda_rekurzivmetodus
{
    class Program
    {
        static int call;

        static long Faktorialis(int n)
        {
            if (n <= 1) { return 1; }
            call++;
            return n * Faktorialis(n - 1);
        }

        static void Main(string[] args)
        {
            for (int i=1; i<21; i++)
            {
                call = 1;
                var fakt = Faktorialis(i);
                Console.WriteLine("{0}, call: {1}", fakt, call);
            }
            Console.ReadKey();
        }
    }
}
