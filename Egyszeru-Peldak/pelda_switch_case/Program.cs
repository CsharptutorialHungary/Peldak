using System;

namespace pelda_switch_case
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

            switch (gomb)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Kis kávét választott");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Nagy kávét választott");
                    break;
                case 'C':
                case 'c':
                    Console.WriteLine("Kár");
                    break;
                default:
                    Console.WriteLine("Nem jó gombot nyomott!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
