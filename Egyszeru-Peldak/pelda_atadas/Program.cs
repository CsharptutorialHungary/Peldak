using System;

namespace pelda_atadas
{
    class osztaly
    {
        public double ertek;
    }

    class Program
    {
        static void ErtekatadoPelda(double ertek)
        {
            ertek = 2.1;
        }

        static void ReferenciaPelda(osztaly referencia)
        {
            referencia.ertek = 2.1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Érték típus példa");
            Console.WriteLine();

            double ertek = 3.14;
            Console.WriteLine("Függvény hívás előtt az ertek: {0}", ertek);
            ErtekatadoPelda(ertek);
            Console.WriteLine("Függvény hívás utan az ertek: {0}", ertek);

            Console.WriteLine();
            Console.WriteLine("Referencia típus példa");
            Console.WriteLine();

            osztaly o = new osztaly();
            o.ertek = 3.14;
            Console.WriteLine("Függvény hívás előtt az ertek: {0}", o.ertek);
            ReferenciaPelda(o);
            Console.WriteLine("Függvény hívás utan az ertek: {0}", o.ertek);
            Console.ReadKey();
        }
    }
}
