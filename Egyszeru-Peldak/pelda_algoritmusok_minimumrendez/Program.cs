using System;

namespace pelda_algoritmusok_minimumrendez
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

        public static int[] MinimumRendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (int i = 0; i < tomb.Length; i++)
            {
                var minimum = i;
                for (int j = i; j < tomb.Length; j++)
                {
                    if (tomb[j] < tomb[minimum]) minimum = j;
                }
                if (tomb[i] != minimum)
                {
                    var tmp = tomb[i];
                    tomb[i] = tomb[minimum];
                    tomb[minimum] = tmp;
                }
            }
            return tomb;
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            Console.WriteLine("Rendezés előtt:");
            TombKiir(tomb);

            Console.WriteLine("Minimum rendezés:");
            var minimum = MinimumRendez(tomb);
            TombKiir(minimum);

            Console.ReadKey();
        }
    }
}
