using System;

namespace pelda_tervminta_factory
{
    class Tanulo
    {
        public string Nev { get; set; }
        public int Evfolyam { get; set; }
        public double Atlag { get; set; }

        public override string ToString()
        {
            return $"{Nev} - {Evfolyam}, Atlag: {Atlag}";
        }
    }

    class Program
    {
        static Random r = new Random();

        public static Tanulo MakeTanulo(string neve)
        {
            return new Tanulo
            {
                Nev = neve,
                Evfolyam = 9,
                Atlag = r.NextDouble()
            };
        }

        static void Main(string[] args)
        {
            Tanulo[] diakok = new Tanulo[]
            {
                MakeTanulo("Gipsz Jakab"),
                MakeTanulo("Teszt Elek"),
                MakeTanulo("Teszt Sára"),
            };
            foreach (var diak in diakok)
            {
                Console.WriteLine(diak);
            }
            Console.ReadKey();
        }
    }
}
