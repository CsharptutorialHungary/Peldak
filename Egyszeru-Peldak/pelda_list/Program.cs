using System;
using System.Collections.Generic;

namespace pelda_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 elemnek foglalunk helyet
            var lista = new List<int>(4);
            lista.Add(9);
            lista.Add(2);
            lista.Add(4);
            lista.Add(5);

            Console.WriteLine("A lista elemei:");
            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }

            lista.Sort(); //int esetén implementálva van a < és > reláció
            Console.WriteLine("A lista elemei sorbarendezés után:");
            foreach (var elem in lista)
            {
                Console.WriteLine(elem);
            }

            //+1 elem. Itt átméretezés lesz.
            //2n alapján a méret 8-ra fog nőni.
            //ez jelen esetben 3*4 byte feleslegesen foglalt memória
            lista.Add(99);

            Console.WriteLine("Lista mérete: {0}", lista.Capacity);
            lista.TrimExcess(); //felesleges foglalás csökkentése
            Console.WriteLine("Átméretezés után: {0}", lista.Capacity);

            Console.ReadKey();

        }
    }
}
