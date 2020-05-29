using System;
using System.Collections.Generic;
using System.Linq;

namespace pelda_linq_join
{
    struct Pelda
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    struct Pelda2
    {
        public int Y { get; set; }
        public int Z { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Pelda> elemek = new List<Pelda>
            {
                new Pelda { X = 10, Y = 20 },
                new Pelda { X = 11, Y = 23 },
                new Pelda { X = 44, Y = 42 },
                new Pelda { X = 7, Y = 1 },
                new Pelda { X = 9, Y = 12 },
            };

            List<Pelda2> elemek2 = new List<Pelda2>
            {
                new Pelda2 { Z = 88, Y = 20 },
                new Pelda2 { Z = 14, Y = 23 },
                new Pelda2 { Z = 63, Y = 42 },
                new Pelda2 { Z = 11, Y = 1 },
                new Pelda2 { Z = 4, Y = 12 },
            };

            var eredmeny = from elem in elemek
                           join elem2 in elemek2 on
                           elem.Y equals elem2.Y
                           select new
                           {
                               X = elem.X,
                               Y = elem.Y,
                               Z = elem2.Z
                           };

            var eredmeny2 = elemek.Join(elemek2, i => i.Y, j => j.Y, (i, j) => new
            {
                X = i.X,
                Y = i.Y,
                Z = j.Z
            });

            foreach (var item in eredmeny)
            {
                Console.WriteLine("{0}, {1}, {2}", item.X, item.Y, item.Z);
            }
            Console.ReadKey();
        }
    }
}
