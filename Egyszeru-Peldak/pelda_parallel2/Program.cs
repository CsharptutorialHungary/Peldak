using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pelda_parallel2
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<int>();
            for (int i = 0; i < 12; i++)
            {
                collection.Add(i);
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Parallel.ForEach(collection, item =>
            {
                Console.WriteLine(item);
            });
            Console.ReadKey();
        }
    }
}
