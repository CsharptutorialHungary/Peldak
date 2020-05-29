using System.Collections.Generic;
using System.Linq;
using System;

namespace pelda_linq_select2
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
                new Pelda { X = 10, Y = 20 },
                new Pelda { X = 11, Y = 23 },
                new Pelda { X = 44, Y = 42 },
                new Pelda { X = 7, Y = 1 },
                new Pelda { X = 9, Y = 12 },
            };

            var eredmeny = from elem in elemek
                           select new
                           {
                               X2 = elem.X*2,
                               Y2 = elem.Y*2
                           };

            var eredmeny2 = elemek.Select(i => new
            {
                X2 = i.X * 2,
                Y2 = i.Y * 2
            });

            foreach (var item in eredmeny)
            {
                Console.WriteLine("{0}, {1}", item.X2, item.Y2);
            }
            Console.ReadKey();
        }
    }
}