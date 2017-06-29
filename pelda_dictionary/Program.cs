using System;
using System.Collections.Generic;

namespace pelda_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            var statisztika = new Dictionary<int, int>(15);

            for (int i=0; i<30; i++)
            {
                var gen = r.Next(0, 15);
                if (statisztika.ContainsKey(gen)) statisztika[gen] += 1;
                else statisztika.Add(gen, 1); 
            }

            foreach (var elem in statisztika)
            {
                Console.WriteLine("{0:00} => {1:00} db", elem.Key, elem.Value);
            }

            Console.ReadKey();
        }
    }
}
