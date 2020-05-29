#define TESZT
using System;

namespace pelda_elofeldolgozo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region összecsukható régió
            //ide egy komolyabb kód szösszenet írható
            //ami összecsukható lesz Visual Studio-ban
            #endregion

#if DEBUG
            Console.WriteLine("DEBUG mód!");
#if TESZT
            Console.WriteLine("Teszt definiálva");
#endif
#else
            Console.WriteLine("RELEASE mód!");
#if TESZT
            Console.WriteLine("Teszt definiálva");
#endif
#endif
            Console.ReadKey();
        }
    }
}
