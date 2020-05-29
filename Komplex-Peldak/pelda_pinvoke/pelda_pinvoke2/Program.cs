using System;

namespace pelda_pinvoke2
{
    class Program
    {
        static void Main(string[] args)
        {
            NativeFibonacci fibonacci = new NativeFibonacci(42);
            fibonacci.Kiir();
            Console.ReadKey();
        }
    }
}
