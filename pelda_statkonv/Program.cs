using System;

namespace pelda_statkonv
{
    class Program
    {
        static void Main(string[] args)
        {
            //0-t ír ki, mivel x int és a 4 is int
            int x = 3;
            Console.WriteLine(x / 4);

            //0,75 mert az x átkonvertálódik double típusra
            Console.WriteLine((double)x / 4);

            Console.ReadKey();
        }
    }
}
