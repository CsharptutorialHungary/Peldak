using System;

namespace pelda_2dtomb
{
    class Program
    {
        static void Main(string[] args)
        {
            //tömb elemeinek meghatározása
            //minden sor külön zárójelet igényel
            var tomb2d = new int[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("Bejárás for ciklusokkal");
            //A length tulajdonság itt nem használható
            //mivel a tömb 2d kiterjedésű. 
            for (int i=0; i<tomb2d.GetLength(0); i++)
            {
                for (int j=0; j<tomb2d.GetLength(1); j++)
                {
                    Console.Write("{0} ", tomb2d[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Bejárás foreach ciklusokkal");
            foreach (var elem in tomb2d)
            {
                Console.Write("{0} ", elem);
            }
            Console.ReadLine();
        }
    }
}
