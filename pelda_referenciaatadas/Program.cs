using System;

namespace pelda_referenciaatadas
{
    class Program
    {
        static void ErtekatadoPelda(ref double ertek)
        {
            ertek = 2.1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Érték típus referenciaként példa");
            Console.WriteLine();

            double ertek = 3.14;
            Console.WriteLine("Függvény hívás előtt az ertek: {0}", ertek);
            ErtekatadoPelda(ref ertek);
            Console.WriteLine("Függvény hívás utan az ertek: {0}", ertek);
            Console.ReadKey();
        }
    }
}
