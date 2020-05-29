using System;

namespace pelda_algoritmus_cseresrendez
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

        public static int[] CseresRendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb.Length; j++)
                {
                    if (tomb[i] < tomb[j])
                    {
                        var tmp = tomb[i];
                        tomb[i] = tomb[j];
                        tomb[j] = tmp;
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

            Console.WriteLine("Cserés rendezés:");
            var cseres = CseresRendez(tomb);
            TombKiir(cseres);
        }
    }
}
