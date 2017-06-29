using System;
using System.Collections.Generic;

namespace pelda_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var verem = new Stack<char>();
            var be = "VEREM RULEZ";

            Console.WriteLine("Verembe írás: {0}", be);

            foreach (var chr in be)
                verem.Push(chr);

            Console.WriteLine("Veremből kiolvasás");

            while (verem.Count > 0)
            {
                var c = verem.Pop();
                Console.Write(c);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
