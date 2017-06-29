using System;

namespace pelda_string_numformat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pénz: {0:C1}", 3148);
            Console.WriteLine("Százalék: {0:P3}", 0.123456);
            Console.WriteLine("Általános: {0:G}", 132354);
            Console.WriteLine("Exponenciális: {0:E}", 132354);
            Console.WriteLine("Hexa: {0:X}", 255);
            Console.ReadKey();
        }
    }
}
