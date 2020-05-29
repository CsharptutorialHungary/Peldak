using System;

namespace pelda_nullceck
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = null;
            if (test != null)
            {
                Console.WriteLine(test.Length);
            }
            Console.ReadKey();
        }
    }
}
