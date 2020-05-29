using System;

namespace pelda_out
{
    class Program
    {
        private static bool Test(out int variable)
        {
            //hibát eredényez:
            //variable = variable + 1; 
            variable = 41;
            return true;
        }

        static void Main(string[] args)
        {
            int test;
            var result = Test(out test);
            Console.WriteLine(result);
            Console.WriteLine(test);
            Console.ReadLine();
        }
    }
}
