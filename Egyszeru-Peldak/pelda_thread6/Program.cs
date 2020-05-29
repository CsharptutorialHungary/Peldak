using System;
using System.Threading;

namespace pelda_thread6
{
    class Program
    {
        [ThreadStatic]
        private static int _eddig;
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                _eddig = 5;
                Console.Write($"\n Elszámolok {_eddig}-ig!");
                for (int i = 0; i < _eddig; i++)
                {
                    Console.Write('A');
                    Thread.Sleep(1000);
                }
                Console.Write($"\n {_eddig}!");
            }).Start();

            new Thread(() =>
            {
                _eddig = 3;
                Console.Write($"\n Elszámolok {_eddig}-ig!");
                for (int i = 0; i < _eddig; i++)
                {
                    Console.Write('B');
                    Thread.Sleep(1000);
                }
                Console.Write($"\n {_eddig}!");
            }).Start();
        }
    }
}
