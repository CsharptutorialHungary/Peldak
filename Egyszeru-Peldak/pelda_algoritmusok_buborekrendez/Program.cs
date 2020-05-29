using System;

namespace pelda_algoritmusok_buborekrendez
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

        public static int[] BuborekRendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            var csere = true;
            for (int i = tomb.Length - 1; i >= 0 && csere; i--)
            {
                csere = false;
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int tmp = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = tmp;
                        csere = true;
                    }
                }
            }
            return tomb;
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            Console.WriteLine("Rendezés előtt:");
            TombKiir(tomb);

            Console.WriteLine("Buborek rendezés:");
            var bubi = BuborekRendez(tomb);
            TombKiir(bubi);

            Console.ReadKey();
        }
    }
}
