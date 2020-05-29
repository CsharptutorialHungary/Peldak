using System;

namespace MEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner runner = new Runner();
            runner.DoLoad();
            runner.Run();

            Console.ReadKey();
        }
    }
}
