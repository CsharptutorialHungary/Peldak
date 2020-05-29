using System;

namespace pelda_oroklodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Teglalap t = new Teglalap(0, 0, 30, 20);
            Negyzet n = new Negyzet(0, 25, 6);
            t.Rajzol();
            n.Rajzol();
            Console.ReadKey();
        }
    }
}
