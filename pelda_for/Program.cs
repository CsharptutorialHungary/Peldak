using System;

namespace pelda_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0 -> 10");
            for (int i=0; i<10; i++)
            {
                Console.Write("{0}, ", i);
            }

            //itt már nem definiálhatunk i változót
            //int i = 22;

            Console.WriteLine("\n10 -> 0");
            for (int i=10; i>=0; i--)
            {
                Console.Write("{0}, ", i);
            }

            Console.WriteLine("\n0 -> 60, minden 3.");
            for (int i = 0; i < 60; i += 3)
            {
                Console.Write("{0}, ", i);
            }
            Console.ReadKey();
        }
    }
}
