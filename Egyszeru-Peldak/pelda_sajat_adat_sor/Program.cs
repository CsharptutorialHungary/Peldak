using System;

namespace pelda_sajat_adat_sor
{
    class Program
    {
        static void Main(string[] args)
        {
            var sor = new SajatSor<int>();
            sor.Enqueue(11);
            sor.Enqueue(12);
            sor.Enqueue(13);
            sor.Enqueue(14);
            sor.Enqueue(15);

            Console.WriteLine("A sor elemei: ");
            foreach (var item in sor)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Dequeue:");
            Console.WriteLine(sor.Dequeue());
            Console.WriteLine(sor.Dequeue());
            Console.WriteLine(sor.Dequeue());
            Console.WriteLine(sor.Dequeue());

            Console.ReadKey();
        }
    }
}
