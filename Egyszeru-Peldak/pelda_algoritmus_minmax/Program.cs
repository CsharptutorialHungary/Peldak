using System;

namespace pelda_algoritmus_minmax
{
    class Program
    {
        public static void MinMax(int[] tomb, out int min, out int max)
        {
            int _min = tomb[0];
            int _max = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < _min) _min = tomb[i];
                if (tomb[i] > _max) _max = tomb[i];
            }
            min = _min;
            max = _max;
        }

        static void Main(string[] args)
        {
            var tomb = new int[] { 9, 6, 0, 0, 1, 2, 2, 2, 3, 1, 5, 4, 8, 2, 8, 6 };

            int min;
            int max;

            MinMax(tomb, out min, out max);
            Console.WriteLine("Minimum: {0}, Maximimum: {1}", min, max);

            Console.ReadKey();
        }
    }
}
