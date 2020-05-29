using System;

namespace pelda_tervminta_singleton
{
    public class Singleton
    {
        //static referencia egy példányra
        private static Singleton _instance;

        //a privát konstruktor megtiltja a new operátoros közvetlen példányosítást
        private Singleton()
        {
            Console.WriteLine("Singleton példányosítva");
        }

        //Példány lekérdezése
        //Lehetne akár Property is
        public static Singleton GetInstance()
        {
            //példányosítás első alkalommal, amikor használjuk
            if (_instance == null)
                _instance = new Singleton();

            return _instance;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton test1 = Singleton.GetInstance();
            Singleton test2 = Singleton.GetInstance();

            if (test1 == test2)
            {
                Console.WriteLine("Tényleg egy példány van");
            }

            Console.ReadKey();
        }
    }
}
