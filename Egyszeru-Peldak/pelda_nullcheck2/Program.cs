using System;

namespace pelda_nullcheck2
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = null;
            Console.WriteLine(test?.Length ?? 0);
            Console.ReadKey();
        }
    }
}
