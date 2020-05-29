using System;

namespace pelda_algoritmus_linkeres
{
    class Program
    {
        public static int Lineariskeres(int[] tomb, int elem)
        {
            int index = -1;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == elem)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            int poz = Lineariskeres(tomb, 2);
            Console.WriteLine("A kettes indexe: {0}", poz);

            Console.ReadKey();

        }
    }
}
