using System;
using System.Collections.Generic;

namespace pelda_algoritmus_megszamol
{
    class Program
    {
        //key: a tömb eleme
        //value: az elem előfordulási száma
        public static Dictionary<int, int> Megszamol(int[] tomb)
        {
            var stat = new Dictionary<int, int>();
            foreach (var elem in tomb)
            {
                if (stat.ContainsKey(elem)) stat[elem] += 1;
                else stat.Add(elem, 1);
            }
            return stat;
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            var stat = Megszamol(tomb);
            Console.WriteLine("Statisztika: ");
            foreach (var elem in stat)
            {
                Console.WriteLine("{0} - {1}db", elem.Key, elem.Value);
            }

            Console.ReadKey();
        }
    }
}
