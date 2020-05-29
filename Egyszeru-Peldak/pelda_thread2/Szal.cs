using System;
using System.Threading;

namespace pelda_thread2
{
    class Szal
    {
        public void TizigSzamol()
        {
            Console.Write("\n Elszámolok tízig!");
            for (int i = 0; i < 10; i++)
            {
                Console.Write('.');
                Thread.Sleep(1000);
            }
            Console.Write("\n Tíz!");
        }
    }
}
