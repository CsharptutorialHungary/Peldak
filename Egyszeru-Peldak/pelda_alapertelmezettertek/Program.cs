using System;

namespace pelda_alapertelmezettertek
{
    class Program
    {
        private static int Osszegez(int meddig=10)
        {
            int osszeg = 0;
            for (int i=1; i<meddig; i++)
            {
                osszeg += i;
            }
            return osszeg;
        }

        /*private static void Nemfordul(int opcionalis=10, int valami)
        {
            ez nem fog lefordulni, mivel a valami kötelező paraméter
            opcionális paraméter pedig csak a kötelező paraméterek után
            szerepelhet
        }*/

        static void Main(string[] args)
        {
            var t1 = Osszegez(); //első 10 szám összege
            var t2 = Osszegez(100); //első 100 szám összege
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.ReadKey();
        }
    }
}
