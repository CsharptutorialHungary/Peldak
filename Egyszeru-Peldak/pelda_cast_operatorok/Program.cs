using System;

namespace pelda_cast_operatorok
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit cast int-ről long-ra majd Tort-re
            Tort pelda = 12;

            Tort pelda2 = new Tort(3, 4);

            //Explicit cast
            decimal eredmeny = (decimal)pelda2;

            Console.WriteLine(eredmeny);

            Console.ReadKey();

        }
    }
}
