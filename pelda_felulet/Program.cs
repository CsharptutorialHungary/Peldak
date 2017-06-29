using System;

namespace pelda_felulet
{
    interface IPeldaFelulet
    {
        void PeldaFuggveny();
    }

    class FeluletImplementacio : IPeldaFelulet
    {
        public void PeldaFuggveny()
        {
            Console.WriteLine("Példa függvény impelementációja");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pelda = new FeluletImplementacio();
            pelda.PeldaFuggveny();
            Console.ReadKey();
        }
    }
}
