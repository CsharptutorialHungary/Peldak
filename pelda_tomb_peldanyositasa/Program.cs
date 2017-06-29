using System;

namespace pelda_tomb_peldanyositasa
{
    //demo osztály 2 adattaggal
    class Demo
    {
        public string Szoveg { get; set; }
        public int Szam { get; set; }

        //alapértelmezett konstruktor
        public Demo()
        {
            Szoveg = "";
            Szam = -1;
        }

        //paraméteres konstruktor
        public Demo(string s, int sz)
        {
            Szoveg = s;
            Szam = sz;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //a tömb példányosítása még
            //nem példámnyosítja az elemeket!
            var Tomb = new Demo[4];

            Tomb[0] = new Demo("Teszt", 42);

            //Object initializer szintaxis
            Tomb[3] = new Demo()
            {
                Szoveg = "Masik",
                Szam = 11
            };

            foreach (var elem in Tomb)
            {
                if (elem == null) Console.WriteLine("null");
                else Console.WriteLine("{0} ; {1}", elem.Szoveg, elem.Szam);
            }

            Console.ReadLine();
        }
    }
}
