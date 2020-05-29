using System;
using System.Collections.Generic;

namespace pelda_lancolt
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new LinkedList<string>();
            //jobbról bővítés
            lista.AddLast("My"); lista.AddLast("Siny");
            lista.AddLast("Metal"); lista.AddLast("Ass");
            //balról bővítés
            lista.AddFirst("Bite");

            Console.WriteLine("Lánc elemek száma: {0}", lista.Count);
            Console.WriteLine("Lánc tartalma előre: ");
            //a foreach automatikusan a value elemet szedi ki
            foreach (var elem in lista)
            {
                Console.Write("{0} ", elem);
            }

            Console.WriteLine("\nLánc tartalma vissza: ");
            var vissza = lista.Last;
            while (vissza != null)
            {
                Console.Write("{0} ", vissza.Value);
                vissza = vissza.Previous;
            }
            Console.ReadKey();
        }
    }
}
