using System;
using System.Threading;

namespace pelda_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Thread.Sleep(10000);
            Console.WriteLine(DateTime.Now);
        }
    }
}
