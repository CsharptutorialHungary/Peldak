using System;

namespace pelda_static_konstruktor
{
    static class Pelda
    {
        private static int Szam;

        //statikus konstruktor
        static Pelda()
        {
            Szam = 5;
        }

        public static void TesztMetodus()
        {
            Console.WriteLine("Még ennyi van hátra: {0}", Szam);
            --Szam;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<5; i++)
            {
                Pelda.TesztMetodus();
            }
            Console.ReadKey();
        }
    }
}
