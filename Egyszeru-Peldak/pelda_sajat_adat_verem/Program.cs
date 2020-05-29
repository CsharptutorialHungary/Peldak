using System;

namespace pelda_sajat_adat_verem
{
    class Program
    {
        static void Main(string[] args)
        {
            var verem = new SajatVerem<int>();
            verem.Push(11);
            verem.Push(12);
            verem.Push(13);
            verem.Push(14);
            verem.Push(15);

            Console.WriteLine("A verem elemei: ");
            foreach (var item in verem)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pop:");
            Console.WriteLine(verem.Pop());

            Console.ReadKey();
        }
    }
}
