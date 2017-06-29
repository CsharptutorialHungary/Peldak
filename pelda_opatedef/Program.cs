using System;

namespace pelda_opatedef
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit teszt
            Pont pi = 22;
            int i = pi;
            Console.WriteLine(pi);
            Console.WriteLine(i);
            Console.WriteLine((bool)pi); //explicit

            var p1 = new Pont(1, 3);
            var p2 = new Pont(2, 3);
            var p3 = new Pont(1, 3);

            Console.WriteLine("p1 + p2: {0}", p1 + p2);
            Console.WriteLine("p1 - p2: {0}", p1 - p2);
            Console.WriteLine("p2++ {0}", p2++);
            Console.WriteLine("p2-- {0}", p2--);
            Console.ReadKey();
        }
    }
}
