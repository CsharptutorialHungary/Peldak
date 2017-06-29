using System;

namespace pelda_2djagged
{
    class Program
    {
        static void Main(string[] args)
        {
            //tömbök tömbje.
            //ha menet közben fogjuk feltölteni
            //akkor a szintaxis eltér:
            //var jagged = new int[3][];
            var jagged = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            foreach (var sor in jagged)
            {
                foreach (var oszlop in sor)
                {
                    Console.Write("{0} ", oszlop);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
