using System;

namespace pelda_delegate3
{
    class Program
    {
        public delegate void Foo();

        static void Implementacio1() { }
        static void Implementacio2() { }

        static void Main(string[] args)
        {
            Foo test1 = null;
            Foo test2 = null;

            Console.WriteLine(test1 == test2); //true

            test1 = Implementacio1;
            test2 = Implementacio2;

            Console.WriteLine(test1 == test2); //false

            test1 = Implementacio1;
            test2 = Implementacio1;

            Console.WriteLine(test1 == test2); //true

            Console.ReadKey();
        }
    }
}
