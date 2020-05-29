using System;

namespace pelda_goto_ciklus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Goto ciklus szervezés");
            int szamlalo = 0;
            ciklus:
            if (szamlalo < 10)
            {
                Console.Write("{0}, ", szamlalo);
                szamlalo++;
                goto ciklus;
            }
            Console.ReadKey();
        }
    }
}
