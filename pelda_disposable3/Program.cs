using System;

namespace pelda_disposable3
{
    class UsingDispose : IDisposable
    {
        public void Metodus()
        {
            Console.WriteLine("Metódus meghívva");
        }

        public void Dispose()
        {
            Console.WriteLine("Using scope vége. Dispose futtatása");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (var objektum = new UsingDispose())
            {
                objektum.Metodus();
            }
            Console.ReadKey();
        }
    }
}
