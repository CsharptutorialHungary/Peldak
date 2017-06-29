using System;

namespace pelda_dowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = -1;
            do
            {
                try
                {
                    Console.WriteLine("Adjon meg egy 1 és 10 közötti páros számot!");
                    string s = Console.ReadLine();
                    szam = Convert.ToInt32(s);
                }
                catch (Exception)
                {
                    szam = -1;
                }
            }
            while ((szam < 1) || (szam > 10) || ((szam % 2) != 0));

            Console.WriteLine("A megadott szám: {0}", szam);
            Console.ReadKey();
        }
    }
}
