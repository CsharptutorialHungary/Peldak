using System;

namespace pelda_algoritmus_shellrendez
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

        public static int[] ShellSort(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            int tavolsag = tomb.Length / 2;
            while (tavolsag > 0)
            {
                //ez egy módosított beszúró rendezés
                for (int i = 0; i < tomb.Length - tavolsag; i++)
                {
                    int j = i + tavolsag;
                    int tmp = tomb[j];
                    while (j >= tavolsag && tmp > tomb[j - tavolsag])
                    {
                        tomb[j] = tomb[j - tavolsag];
                        j -= tavolsag;
                    }
                    tomb[j] = tmp;
                }
                if (tavolsag == 2) tavolsag = 1;
                else tavolsag = (int)(tavolsag / 2.2);
            }
            return tomb;
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            Console.WriteLine("Rendezés előtt:");
            TombKiir(tomb);

            Console.WriteLine("Shell rendezés:");
            var shell = ShellSort(tomb);
            TombKiir(shell);

            Console.ReadKey();
        }
    }
}
