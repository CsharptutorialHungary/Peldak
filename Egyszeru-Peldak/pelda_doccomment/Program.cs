using System;

namespace pelda_doccomment
{
    /// <summary>
    /// Segéd metódusok
    /// </summary>
    static class Helpers
    {
        /// <summary>
        /// Számok összeadása
        /// </summary>
        /// <param name="szamok">Összeadandó számok</param>
        /// <returns>Számok összege</returns>
        public static double Ossszead(params double[] szamok)
        {
            double szum = 0;
            foreach (var szam in szamok)
            {
                szum += szam;
            }
            return szum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double eredmeny = Helpers.Ossszead(12, 16);
            Console.WriteLine("Az összeadás eredménye: {0}", eredmeny);
            Console.ReadKey();
        }
    }
}
