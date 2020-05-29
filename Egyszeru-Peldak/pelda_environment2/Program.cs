using System;

namespace pelda_environment2
{
    class Program
    {
        static void Main(string[] args)
        {
            var specials = (Environment.SpecialFolder[])Enum.GetValues(typeof(Environment.SpecialFolder));
            foreach (var special in specials)
            {
                Console.WriteLine("Environment.{0} - {1}", special, Environment.GetFolderPath(special));
            }
            Console.ReadKey();
        }
    }
}
