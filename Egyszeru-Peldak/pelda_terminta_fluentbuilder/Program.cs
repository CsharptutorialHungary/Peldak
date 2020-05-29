using System;

namespace pelda_terminta_fluentbuilder
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

        public Tanulo()
        {
            Nev = "";
            Evfolyam = 1;
            Atlag = 0;
        }
    }

    class TanuloBuilder
    {
        private Tanulo _tanulo;

        public TanuloBuilder UjTanulo()
        {
            _tanulo = new Tanulo();
            return this;
        }

        public TanuloBuilder SetNev(string neve)
        {
            _tanulo.Nev = neve;
            return this;
        }

        public TanuloBuilder SetEvfolyam(int evfolyam)
        {
            _tanulo.Evfolyam = evfolyam;
            return this;
        }

        public TanuloBuilder SetAtlag(double atlag)
        {
            _tanulo.Atlag = atlag;
            return this;
        }

        public Tanulo Build()
        {
            return _tanulo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TanuloBuilder builder = new TanuloBuilder();

            Tanulo teszt = builder.UjTanulo()
                                   .SetNev("Teszt elek")
                                   .SetEvfolyam(3)
                                   .SetAtlag(3.14)
                                   .Build();

            Console.WriteLine(teszt);
            Console.ReadKey();
        }
    }
}
