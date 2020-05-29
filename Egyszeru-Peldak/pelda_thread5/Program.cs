using System;
using System.Threading;

namespace pelda_thread5
{
    class Program
    {
        private static int _eddig;
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                _eddig = 5;
                Console.Write($"\n Elszámolok {_eddig}-ig!");
                for (int i = 0; i < _eddig; i++)
                {
                    Console.Write('.');
                    Thread.Sleep(1000);
                }
                Console.Write($"\n {_eddig}!");
            }).Start();
        }
    }
}
