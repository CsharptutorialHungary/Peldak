using System;

namespace pelda_tomb
{
    class Program
    {
        static void Main(string[] args)
        {
            var gyumolcsok = new string[]
            {
                "alma", "körte", "szilva"
            };

            var bevitelek = new string[3];

            for (int i=0; i<3; i++)
            {
                Console.WriteLine("{0}. bevitel: ");
                bevitelek[i] = Console.ReadLine();
            }

            foreach (var gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcsok);
            }
            foreach (var bevitel in bevitelek)
            {
                Console.WriteLine(bevitel);
            }

            Console.ReadLine();
        }
    }
}
