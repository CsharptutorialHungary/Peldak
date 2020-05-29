using System;

namespace pelda_appdomain
{
    class Program
    {
        static void Main(string[] args)
        {
            //jelenlegi App Domain nevének lekérdezése
            var currentAppDomain = AppDomain.CurrentDomain;
            Console.WriteLine(currentAppDomain.FriendlyName);

            //2. App domain létrehozása
            var second = AppDomain.CreateDomain("masodik");
            Console.WriteLine(currentAppDomain.FriendlyName);

            //2. megszüntetése
            AppDomain.Unload(second);

            Console.ReadKey();
        }
    }
}
