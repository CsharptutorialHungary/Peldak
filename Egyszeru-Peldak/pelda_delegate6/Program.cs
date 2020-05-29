using System;

namespace pelda_delegate6
{
    class Program
    {
        delegate void Foo(int p);

        static void Main(string[] args)
        {
            Foo f = delegate (int p)
            {
                Console.WriteLine("p: {0}", p);
            };

            f(2);

            Console.ReadKey();

        }
    }
}
