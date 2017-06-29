using System;

namespace pelda_ifelse_sok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü program");
            Console.WriteLine("Opciók:");
            Console.WriteLine("A: Kis kávé, B: Nagy kávé");
            Console.WriteLine("C: nem iszok semmit");
            Console.Write("Kérem válasszon!: ");
            var gomb = (char)Console.Read();

            if (gomb == 'A' || gomb == 'a')
            {
                Console.WriteLine("Kis kávét választott");
            }
            else if (gomb == 'B' || gomb == 'b')
            {
                Console.WriteLine("Nagy kávét választott");
            }
            else if (gomb == 'C' || gomb == 'c')
            {
                Console.WriteLine("Kár");
            }
            else
            {
                Console.WriteLine("Nem jó gombot nyomott!");
            }
            Console.ReadKey();
        }
    }
}
