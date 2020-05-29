using System;

namespace pelda_math
{
    class Program
    {
        static void Main(string[] args)
        {
            var sugar = 12; 
            Console.WriteLine("Kör kerület és terület számító.");
            Console.WriteLine("Kör sugara: {0}", sugar);

            var kerulet = Math.PI * 2 * sugar;
            var terulet = Math.Pow(sugar, 2) * Math.PI;

            Console.WriteLine("A kör kerülete: {0}", kerulet);
            Console.WriteLine("A kör területe: {0}", terulet);

            Console.ReadLine();
        }
    }
}
