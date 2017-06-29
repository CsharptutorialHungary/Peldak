using System;

namespace pelda_algoritmusok
{
    class Program
    {
        static void TombKiir(int[] tomb)
        {
            foreach (var elem in tomb)
            {
                Console.Write("{0}, ", elem);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            int min = 0;
            int max = 0;

            Algoritmusok.MinMax(tomb, out min, out max);
            Console.WriteLine("Minimum: {0}, Maximimum: {1}", min, max);

            var stat = Algoritmusok.Statisztika(tomb);
            Console.WriteLine("Statisztika: ");
            foreach(var elem in stat)
            {
                Console.WriteLine("{0} - {1}", elem.Key, elem.Value);
            }

            int poz = Algoritmusok.Lineariskeres(tomb, 2);
            Console.WriteLine("A kettes indexe: {0}", poz);

            Console.WriteLine("Rendezés előtt:");
            TombKiir(tomb);

            Console.WriteLine("Cserés rendezés:");
            var cseres = Algoritmusok.CseresRendez(tomb);
            TombKiir(cseres);

            Console.WriteLine("Minimum rendezés:");
            var minimum = Algoritmusok.MinimumRendez(tomb);
            TombKiir(minimum);

            Console.WriteLine("Buborek rendezés:");
            var bubi = Algoritmusok.BuborekRendez(tomb);
            TombKiir(bubi);

            Console.WriteLine("Beszúró rendezés:");
            var beszur = Algoritmusok.Beszurorendez(tomb);
            TombKiir(beszur);

            Console.WriteLine("Shell rendezés:");
            var shell = Algoritmusok.ShellSort(tomb);
            TombKiir(shell);

            Console.WriteLine("Gyors rendezés:");
            Algoritmusok.Gyorsrendez(tomb);
            TombKiir(tomb);

            int index = Algoritmusok.BinarisKeres(tomb, 8);
            //int index = Array.BinarySearch(tomb, 8);
            Console.WriteLine("A nyolcas indexe: {0}", index);

            Console.ReadKey();
        }
    }
}
