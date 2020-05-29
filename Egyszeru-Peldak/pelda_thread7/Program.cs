using System;
using System.Threading;

namespace pelda_thread7
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((x) =>
            {
                Console.WriteLine("Thread pool művelet");
            });

            Console.ReadKey();
        }
    }
}
