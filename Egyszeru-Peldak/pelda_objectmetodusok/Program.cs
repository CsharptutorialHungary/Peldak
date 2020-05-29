using System;

namespace pelda_objectmetodusok
{
    class peldaOsztaly
    {
        public int Egesz { get; set; }
        public string Szoveg { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Szoveg, Egesz);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ Egesz.GetHashCode();
                hash = (hash * 16777619) ^ Szoveg.GetHashCode();
                return hash;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            peldaOsztaly masik = obj as peldaOsztaly;
            if (masik == null) return false;
            return (Egesz == masik.Egesz) &&
                   (Szoveg == masik.Szoveg);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            peldaOsztaly a = new peldaOsztaly()
            {
                Egesz = 42,
                Szoveg = "A objektum"
            };
            peldaOsztaly b = new peldaOsztaly()
            {
                Egesz = 33,
                Szoveg = "B objektum"
            };
            peldaOsztaly c = new peldaOsztaly()
            {
                Egesz = 42,
                Szoveg = "A objektum"
            };
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine("Hash a: {0} ; b = {1} ; c = {2}",
                              a.GetHashCode(),
                              b.GetHashCode(),
                              c.GetHashCode());
            Console.WriteLine("a == b: {0}", a.Equals(b));
            Console.WriteLine("a == c: {0}", a.Equals(c));
            Console.WriteLine("a == c: {0}", a == c);
            Console.ReadKey();
        }
    }
}
