using System;

namespace Pelda.Lib
{
    //csak a Pelda.Lib.dll fájlon belül látható
    //mivel internal
    internal static class Belso
    {
        public const int All = 42;
    }

    public class PeldaOsztaly
    {
        public void Hello()
        {
            Console.WriteLine("Hello. A szamom: {0}", Belso.All);
        }
    }
}
