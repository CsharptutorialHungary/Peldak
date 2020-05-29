using System;

namespace pelda_konstruktorok
{
    class KonstruktorPelda
    {
        private int _szam;

        //paraméter nélküli konstruktor
        public KonstruktorPelda()
        {
            _szam = 42;
        }

        //paraméteres konstruktor
        public KonstruktorPelda(int szam)
        {
            _szam = szam;
        }

        public void Kiir()
        {
            Console.WriteLine(_szam);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new KonstruktorPelda();
            var b = new KonstruktorPelda(33);
            a.Kiir();
            b.Kiir();
            Console.ReadKey();
        }
    }
}
