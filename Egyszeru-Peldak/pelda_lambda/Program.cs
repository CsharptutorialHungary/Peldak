using System;

namespace pelda_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> negyzet = (x) => (x * x);

            Console.WriteLine("3 négyzete: {0}", negyzet(3));

            Console.ReadKey();

        }
    }
}
