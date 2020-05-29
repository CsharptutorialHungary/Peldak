using System;
using System.Threading;

namespace pelda_thread5b
{
    class Program
    {
        private static int _eddig;

        public static void Main()
        {
            //szálon kívülről beállítás
            _eddig = 5;
            //szál indítása
            new Thread(() =>
            {
                Console.Write($"\n Elszámolok {_eddig}-ig!");
                for (int i = 0; i < _eddig; i++)
                {
                    Console.Write('A');
                    Thread.Sleep(1000);
                }
                Console.Write($"\n {_eddig}!");
            }).Start();
            _eddig = 3;
            new Thread(() =>
            {
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
