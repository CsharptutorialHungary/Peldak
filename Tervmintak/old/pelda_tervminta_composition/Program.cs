using System;

namespace pelda_tervminta_composition
{
    interface IPrint
    {
        void Print();
    }

    interface INeveVan
    {
        string Name { get; }
    }

    class Pelda : IPrint, INeveVan
    {
        public string Name => "Példa osztály";

        public void Print()
        {
            Console.WriteLine("Én tudok írni a konzolra");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pelda p = new Pelda();

            if (p is INeveVan neves)
            {
                Console.WriteLine(neves.Name);
            }
            if (p is IPrint printable)
            {
                printable.Print();
            }
            Console.ReadKey();
        }
    }
}
