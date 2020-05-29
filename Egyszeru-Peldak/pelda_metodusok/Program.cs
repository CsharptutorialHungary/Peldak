using System;

namespace pelda_metodusok
{
    class Program
    {
        static double Oszt(double p1, double p2)
        {
            return p1 / p2;
        }

        static int Oszt(int p1, int p2)
        {
            return p1 / p2;
        }

        static void Main(string[] args)
        {
            var elso = Oszt(3, 4);
            var masodik = Oszt(3.0, 4.0);
            Console.WriteLine(elso);
            Console.WriteLine(masodik);
            Console.ReadKey();
        }
    }
}
