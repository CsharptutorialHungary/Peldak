using System;
using System.Globalization;

namespace pelda_lokalizalas
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = CultureInfo.CurrentUICulture;
            var cul = CultureInfo.CurrentCulture;
            var ang = CultureInfo.CreateSpecificCulture("en-US");

            double d = 1.2579;

            Console.WriteLine("Ui: {0}", ui.Name);
            Console.WriteLine("Culture: {0}", cul.Name);

            var cult_s = string.Format(cul, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
            var ang_s = string.Format(ang, "{0}, {1}, {2:C}", d, DateTime.Now, 32580);
            Console.WriteLine(cult_s);
            Console.WriteLine(ang_s);

            var angolformat = Convert.ToDouble("3.14", ang);
            Console.WriteLine(angolformat);

            Console.ReadKey();

        }
    }
}
