using System;

namespace recordString
{
    record class Pelda
    {
        public int Szam { get; init; }
        public int Szam2 { get; init; }

        public sealed override string ToString()
        {
            return $"Szam1: {Szam}; Szam2: {Szam2}";
        }
    }

    record class PeldaGyerek : Pelda 
    {
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var p = new Pelda
            {
                Szam = 42,
                Szam2 = 13,
            };
            var p2 = new PeldaGyerek
            {
                Szam = 42,
                Szam2 = 13,
            };

            Console.WriteLine(p);
            Console.WriteLine(p2);
            Console.ReadKey();
        }
    }
}
