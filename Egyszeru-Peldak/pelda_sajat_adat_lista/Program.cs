using System;

namespace pelda_sajat_adat_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            SajatLista<int> lista = new SajatLista<int>();

            lista.Add(22);
            lista.Add(33);
            lista.Add(88);
            lista.Add(44);

            Console.WriteLine("A lista ennyi elemet tartalmaz {0}", lista.Count);

            bool vanbenne = lista.Contains(33);
            Console.WriteLine("Van benne 33?: {0}", vanbenne);
            lista.Remove(33);
            vanbenne = lista.Contains(33);
            Console.WriteLine("Van benne 33?: {0}", vanbenne);

            lista.Insert(1, 11);

            Console.WriteLine("A lista elemei:");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }
    }
}
