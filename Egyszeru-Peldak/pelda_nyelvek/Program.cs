using System;
using System.Globalization;
using System.Threading;

namespace pelda_nyelvek
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Console.WriteLine(Properties.Resources.HelloWorld);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("hu-HU");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("hu-HU");

            Console.WriteLine(Properties.Resources.HelloWorld);

            Console.ReadKey();
        }
    }
}
