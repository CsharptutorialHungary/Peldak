using System;

namespace pelda_algoritmus_gyorsrendez
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

        public static void Gyorsrendez(int[] tomb, int eleje = 0, int vege = -1)
        {
            if (vege == -1) vege = tomb.Length - 1;
            if (eleje < vege)
            {
                int kozepe = Feloszt(tomb, eleje, vege);
                Gyorsrendez(tomb, eleje, kozepe - 1);
                Gyorsrendez(tomb, kozepe + 1, vege);
            }
        }

        private static int Feloszt(int[] tomb, int eleje, int vege)
        {
            int kozepe = tomb[vege];
            int kozepindex = eleje;

            for (int i = eleje; i < vege; i++)
            {
                if (tomb[i] <= kozepe)
                {
                    int temp = tomb[i];
                    tomb[i] = tomb[kozepindex];
                    tomb[kozepindex] = temp;
                    kozepindex++;
                }
            }

            int kozepindexErteke = tomb[kozepindex];
            tomb[kozepindex] = tomb[vege];
            tomb[vege] = kozepindexErteke;
            return kozepindex;
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            Console.WriteLine("Rendezés előtt:");
            TombKiir(tomb);

            Console.WriteLine("Gyors rendezés:");
            Gyorsrendez(tomb);
            TombKiir(tomb);

            Console.ReadKey();
        }
    }
}
