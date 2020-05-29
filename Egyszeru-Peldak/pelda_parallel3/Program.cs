using System;
using System.Collections.Generic;
using System.Linq;

namespace pelda_parallel3
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

            var q = from c in collection.AsParallel()
                    where c % 5 == 0
                    select c;

            q.ForAll(x => Console.WriteLine(x));

            Console.ReadKey();

        }
    }
}
