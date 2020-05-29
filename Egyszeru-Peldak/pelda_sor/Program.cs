using System;
using System.Collections.Generic;

namespace pelda_sor
{
    class Program
    {
        static void Main(string[] args)
        {
            var sor = new Queue<char>();
            var be = "SOR RULEZ";

            Console.WriteLine("Sorba írás: {0}", be);

            foreach (var chr in be)
                sor.Enqueue(chr);

            Console.WriteLine("Sorból kiolvasás");

            while (sor.Count > 0)
            {
                var c = sor.Dequeue();
                Console.Write(c);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
