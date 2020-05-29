using System;

namespace pelda_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break példa");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 10) break;
            }

            Console.WriteLine("Continue példa");
            int j = 30;
            while (j-- > 0)
            {
                if (j % 3 == 0) continue;
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
    }
}