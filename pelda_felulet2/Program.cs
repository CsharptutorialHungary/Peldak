using System;

namespace pelda_felulet2
{
    interface IEgyik
    {
        string Nevem();
    }

    interface IMasik
    {
        string Nevem();
    }

    class Implementacio : IEgyik, IMasik
    {
        //alapértelmezetten az objektum IMasik
        public string Nevem()
        {
            return "IMasik implementáció";
        }

        //Explicit implementáció
        //megfelelő konvertálás nélkül nem hívható
        string IEgyik.Nevem()
        {
            return "IEgyik implementáció";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var imp = new Implementacio();
            Console.WriteLine(imp.Nevem());
            IEgyik i = imp;
            //konvertálás után hívható az implementáció
            Console.WriteLine(i.Nevem());
            Console.ReadKey();

        }
    }
}
