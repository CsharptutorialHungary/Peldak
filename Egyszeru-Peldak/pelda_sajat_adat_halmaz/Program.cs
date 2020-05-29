using System;

namespace pelda_sajat_adat_halmaz
{
    class Program
    {
        static void Main(string[] args)
        {
            SajatHalmaz<string> Test = new SajatHalmaz<string>(3);

            Test.Add("Hello");
            Test.Add("World");
            Test.Add("Pelda");

            Console.WriteLine("A halmaz elemei:");
            foreach (var item in Test)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            bool vanbenne = Test.Contains("Hello");
            Console.WriteLine("Van benne Hello: {0}", vanbenne);

            vanbenne = Test.Contains(":(");
            Console.WriteLine("Van benne :( : {0}", vanbenne);

            Console.ReadKey();
        }
    }
}
