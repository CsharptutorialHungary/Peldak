using System;

namespace pelda_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem adjon meg egy számot");
            var bevitel = Console.ReadLine();

            int x = Convert.ToInt32(bevitel);

            if (x >= 20) Console.WriteLine("Nagyobb vagy egyenlő  20");
            else if (x >= 10) Console.WriteLine("Nagyobb vagy egyenlő 10");
            else Console.WriteLine("Vagy kisebb, mint 10");

            //Komplex feltétel, zárójelezés fontos!
            if (((x % 2) == 0) && (x > 0))
            {
                Console.WriteLine("A megadott szám páros és nem nulla");
            }
            else Console.WriteLine("Páratlan vagy nulla");

            Console.ReadKey();
        }
    }
}
