using System;
using System.Collections.Generic;
using System.Linq;

namespace pelda_parallel4
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new List<int>();
            for (int i = 0; i < 444; i += 2)
            {
                collection.Add(i);
            }

            var q = from c in collection.AsParallel().AsOrdered()
                    where c % 5 == 0
                    select c;
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
