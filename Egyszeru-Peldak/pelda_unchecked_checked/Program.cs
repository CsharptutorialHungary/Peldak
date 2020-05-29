using System;

namespace pelda_unchecked_checked
{
    class Program
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int ertek = int.MaxValue + 100;
                checked
                {
                    //fordítási hibát okoz
                    //int ertek2 = int.MaxValue * 2;
                }
                Console.WriteLine(ertek);
                Console.ReadKey();
            }
        }
    }
}
