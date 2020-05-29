using System;

namespace pelda_reszleges_metodus
{
    partial class Reszleges
    {
        partial void Metodus();

        public Reszleges()
        {
            Metodus();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Reszleges r = new Reszleges();
            Console.ReadKey();
        }
    }
}
