using System;
using System.Threading.Tasks;

namespace pelda_parallel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            Parallel.For(0, 12, (i) =>
            {
                Console.WriteLine(i);
            });
            Console.ReadKey();
        }
    }
}
