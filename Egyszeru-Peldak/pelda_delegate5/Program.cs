using System;

namespace pelda_delegate5
{
    class Allat { }

    class Novenyevo : Allat { }

    class Husevo : Allat { }

    delegate Allat ReturnAllat();

    class Program
    {
        static Husevo ReturnsHusevo() { return new Husevo(); }

        static Novenyevo ReturnsNovenyevo() { return new Novenyevo(); }

        static void Main(string[] args)
        {
            ReturnAllat hivo = ReturnsHusevo;

            Allat result = hivo();

            Console.WriteLine(result.GetType()); //Husevo

            hivo = ReturnsNovenyevo;
            result = hivo();

            //castolni kell.
            //Pattern match vagy as operátorral szebb és jobb lenne
            Novenyevo cast = (Novenyevo)result;

            Console.WriteLine(result.GetType()); //Novenyevo

            Console.ReadKey();
        }
    }
}
