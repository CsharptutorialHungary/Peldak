using System;

namespace pelda_lambda2
{
    class Egyszeru
    {
        private int _x;

        public int X
        {
            get => _x * 2;
            set => _x = value;
        }

        public override string ToString() => "Egyszerű osztály";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Egyszeru e = new Egyszeru();

            Console.WriteLine(e);
            e.X = 10;
            Console.WriteLine(e.X);

            Console.ReadKey();
        }
    }
}
