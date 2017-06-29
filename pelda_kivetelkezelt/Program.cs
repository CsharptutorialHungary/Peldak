using System;

namespace pelda_futasidejuhiba2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string s = "valami szöveg";
                int szam = Convert.ToInt32(s);
                Console.WriteLine(szam);

            }
            catch (FormatException)
            {
                Console.WriteLine("Valami hiba történt");
            }
            Console.ReadKey();
        }
    }
}
