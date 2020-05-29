using System;
using System.Collections.Generic;
using System.Linq;

namespace pelda_linq_rendezes1
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
                           orderby elem.X ascending
                           select elem;

            var eredmeny2 = elemek.OrderBy(i => i.X);

            foreach (var item in eredmeny)
            {
                Console.WriteLine("{0}, {1}", item.X, item.Y);
            }
            Console.ReadKey();
        }
    }
}
