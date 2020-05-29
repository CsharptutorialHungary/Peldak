using System;

namespace pelda_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goto példa. Kilépés: CTRL+C");
            eleje:
                Console.WriteLine("Add meg a neved");
                var nev = Console.ReadLine();
                Console.WriteLine("Szia {0}!", nev);
                goto eleje;
        }
    }
}
