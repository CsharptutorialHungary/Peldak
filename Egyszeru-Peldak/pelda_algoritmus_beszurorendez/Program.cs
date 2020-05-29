using System;

namespace pelda_algoritmus_beszurorendez
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

        public static int[] Beszurorendez(int[] bemenet)
        {
            int[] tomb = new int[bemenet.Length];
            Array.Copy(bemenet, tomb, bemenet.Length);
            for (var i = 0; i < tomb.Length - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (tomb[j - 1] > tomb[j])
                    {
                        var temp = tomb[j - 1];
                        tomb[j - 1] = tomb[j];
                        tomb[j] = temp;
                    }
                    j--;
                }
            }
            return tomb;
        }


        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            Console.WriteLine("Rendezés előtt:");
            TombKiir(tomb);

            Console.WriteLine("Beszúró rendezés:");
            var beszur = Beszurorendez(tomb);
            TombKiir(beszur);

            Console.ReadKey();
        }
    }
}
