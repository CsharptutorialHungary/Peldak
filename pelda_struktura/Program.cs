using System;

namespace pelda_struktura
{
    public struct Pont
    {
        //16 byte adat :)
        public double x, y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //nem kell hívni konstruktort, mert
            //automatikusan meghívódik
            Pont pont;

            pont.x = 23;
            pont.y = 11;

            Console.WriteLine("x: {0}, y: {1}", pont.x, pont.y);
            Console.ReadKey();
        }
    }
}
