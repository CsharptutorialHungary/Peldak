using System;

namespace pelda_sajat_adat_lancoltlista
{
    class Program
    {
        static void Main(string[] args)
        {
            SajatLancoltLista<string> Test = new SajatLancoltLista<string>();

            Test.Add("Hello");
            Test.Add("World");
            Test.Add("Pelda");
            Test.Add("Lancolt");

            Console.WriteLine("A láncolt lista elemei:");
            foreach (var item in Test)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Test.Remove("Hello");

            Console.WriteLine("A láncolt lista elemei törlés után:");
            foreach (var item in Test)
            {
                Console.WriteLine(item);
            }

            bool vanbenne = Test.Contains("Hello");
            Console.WriteLine("Van benne Hello: {0}", vanbenne);

            Console.ReadKey();
        }
    }
}
