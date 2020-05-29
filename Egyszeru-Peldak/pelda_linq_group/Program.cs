using System;
using System.Collections.Generic;
using System.Linq;

namespace pelda_linq_group
{
    struct Pelda
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pelda> elemek = new List<Pelda>
            {
                new Pelda { X = 33, Y = 11 },
                new Pelda { X = 88, Y = 12 },
                new Pelda { X = 44, Y = 11 },
                new Pelda { X = 7, Y = 12 },
                new Pelda { X = 9, Y = 11 },
            };

            var eredmeny = from elem in elemek
                           group elem
                           by elem.Y into csoport
                           select csoport;

            var eredmeny2 = elemek.GroupBy(i => i.Y);

            foreach (var group in eredmeny)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine("{0}, {1}", item.X, item.Y);
                }
            }
            Console.ReadKey();
        }
    }
}
