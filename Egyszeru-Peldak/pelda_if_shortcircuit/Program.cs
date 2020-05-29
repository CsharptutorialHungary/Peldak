using System;

namespace pelda_if_shortcircuit
{
    class Program
    {
        static bool Teszt1()
        {
            Console.WriteLine("Teszt1 kiértékelése...");
            return false;
        }


        static bool Teszt2()
        {
            Console.WriteLine("Teszt2 kiértékelése...");
            return true;
        }

        static void Main(string[] args)
        {
            if (Teszt1() & Teszt2())
            {
                //Mindkét metódus lefut a tesztelés közben
            }
            Console.WriteLine();

            if (Teszt1() | Teszt2())
            {
                //Mindkét metódus lefut a tesztelés közben
            }
            Console.WriteLine();

            if (Teszt1() && Teszt2())
            {
                //Teszt2 nem hívódik meg
            }
            Console.WriteLine();

            if (Teszt2() || Teszt1())
            {
                //Teszt1 nem hívódik meg
            }
            Console.ReadLine();
        }
    }
}
