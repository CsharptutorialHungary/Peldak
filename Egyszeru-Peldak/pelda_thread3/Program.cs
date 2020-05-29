using System;
using System.Threading;

namespace pelda_thread3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Console.Write($"\n Elszámolok tízig!");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write('.');
                    Thread.Sleep(1000);
                }
                Console.Write($"\n Tíz!");
            }).Start();
        }
    }
}
