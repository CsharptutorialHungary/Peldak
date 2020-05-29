using System;

namespace pelda_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var abc = "abcdefghijklmnopqrstuvwxyz";
            foreach (var betu in abc)
            {
                Console.WriteLine(betu);
            }
            Console.ReadKey();
        }
    }
}
