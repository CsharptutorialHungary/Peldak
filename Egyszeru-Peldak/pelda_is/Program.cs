using System;

namespace pelda_is
{
    class Osztaly1 { }
    class Osztaly2 { }
    class Osztaly3 : Osztaly2 { }

    class Program
    {
        static void Tesztel(object o)
        {
            if (o is Osztaly1)
            {
                Console.WriteLine("o típusa Osztaly1");
            }
            else if (o is Osztaly2)
            {
                Console.WriteLine("o típusa Osztaly2");
                //itt Osztaly2 és Osztaly3 esetén is!
            }
            else
            {
                Console.WriteLine("o számomra ismeretlen típusú");
            }
        }

        static void Main(string[] args)
        {
            var c1 = new Osztaly1();
            var c2 = new Osztaly2();
            var c3 = new Osztaly3();
            Tesztel(c1);
            Tesztel(c2);
            Tesztel(c3);
            Tesztel("Szöveg");
            Console.ReadLine();
        }
    }
}
