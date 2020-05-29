using System;
using System.Collections.Generic;

namespace pelda_tervminta_template
{
    abstract class Allat
    {
        public abstract void Eszik();
        public abstract void Alszik();
    }

    class Medve : Allat
    {
        public override void Alszik()
        {
            Console.WriteLine("A medve téli álmot alszik.");
        }

        public override void Eszik()
        {
            Console.WriteLine("A medve mindent is megeszik.");
        }
    }

    class Macska : Allat
    {
        public override void Alszik()
        {
            Console.WriteLine("A Macska napi 12 órát alszik.");
        }

        public override void Eszik()
        {
            Console.WriteLine("A Macska húst eszik.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Allat> allatok = new List<Allat>
            {

            };

            foreach (var allat in allatok)
            {
                allat.Eszik();
                allat.Alszik();
            }

            Console.ReadKey();

        }
    }
}
