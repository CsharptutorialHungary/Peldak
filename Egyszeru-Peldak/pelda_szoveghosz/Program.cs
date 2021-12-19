using System;
using System.Globalization;

namespace PeldaszovegHossz
{
    class Program
    {
        static void Main(string[] args)
        {
            string teszt = "🐰";
            Console.WriteLine("A szoveg hossza: {0}", teszt.Length);

            var info = new StringInfo(teszt);
            Console.WriteLine("A szoveg valodi hossza: {0}", info.LengthInTextElements);

            Console.ReadKey();

        }
    }
}