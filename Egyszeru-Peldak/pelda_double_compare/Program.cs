using System;

namespace pelda_double_compare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double doubleX = 0d;
            for (int i = 0; i < 10; i++)
            {
                doubleX += 0.1d;
            }
            doubleX *= 8d;
            double doubleY = 8d;

            Console.WriteLine("Double:");
            Console.WriteLine(doubleX);
            Console.WriteLine(doubleY);
            Console.WriteLine("doubleX == doubleY: {0}", doubleX == doubleY);

            float floatX = 0f;
            for (int i = 0; i < 10; i++)
            {
                floatX += 0.1f;
            }
            floatX *= 8f;
            float floatY = 8f;

            Console.WriteLine();
            Console.WriteLine("Float:");
            Console.WriteLine(floatX);
            Console.WriteLine(floatY);
            Console.WriteLine("floatX == floatY: {0}", floatX == floatY);
        }
    }
}