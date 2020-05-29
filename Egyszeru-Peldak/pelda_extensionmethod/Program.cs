using System;

namespace pelda_extensionmethod
{
    static class Extensions
    {
        public static void PrintJovoEv(this DateTime date)
        {
            Console.WriteLine("A jövő év: {0}", date.Year * 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DateTime.Now.PrintJovoEv();
            Console.ReadKey();
        }
    }
}
