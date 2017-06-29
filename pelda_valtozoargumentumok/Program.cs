using System;

namespace pelda_valtozoargumentumok
{
    class Program
    {
        private static int Osszegez(params int[] szamok)
        {
            int osszeg = 0;
            foreach (var szam in szamok)
            {
                osszeg += szam;
            }
            return osszeg;
        }

        static void Main(string[] args)
        {
            var t1 = Osszegez(1, 2); //3
            var t2 = Osszegez(5, 10, 15, 30); //60
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.ReadKey();
        }
    }
}
