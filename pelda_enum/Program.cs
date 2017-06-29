using System;

namespace pelda_enum
{
    class Program
    {
        enum Hetnapjai : byte
        {
            Hetfo = 1,
            Kedd,
            Szerda,
            Csutortok,
            Pentek,
            Szombat,
            Vasarnap
        }


        static void Main(string[] args)
        {
            string[] tesztek = { "1", "7", "99", "Hetfo", "Szerda", "Pentek", "pentek", "Hiba" };
            foreach (var teszt in tesztek)
            {
                try
                {
                    Hetnapjai nap = (Hetnapjai)Enum.Parse(typeof(Hetnapjai), teszt);
                    Console.WriteLine(nap);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Hiba: " + ex.Message);
                }
                Hetnapjai nap2 = Hetnapjai.Hetfo; //alap érték
                Enum.TryParse<Hetnapjai>(teszt, out nap2); //generikus tryparse hívás
                Console.WriteLine(nap2);
            }
            Console.ReadKey();
        }
    }
}
