using System;

namespace pelda_null_kezeles
{
    class Egyszeru
    {
        private int _szam;

        public Egyszeru()  { _szam = 42; }

        public void Metodus()
        {
            Console.WriteLine("A tárolt számom: {0}", _szam);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Egyszeru valtozo = null;
            //futás idejű hiba
            //valtozo.Metodus();

            //korrekt kezelés #1
            if (valtozo != null) valtozo.Metodus();

            //korrekt kezelés #2
            valtozo?.Metodus();

            //korrekt kezelés #3
            try
            {
                valtozo.Metodus();
            }
            catch (NullReferenceException) { }

            //nagyon nem korrekt kezelés:
            try
            {
                valtozo.Metodus();
            }
            catch (Exception) { }

            Console.ReadKey();
        }
    }
}
