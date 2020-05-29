using System;
using System.Collections;

namespace pelda_environment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Környezeti változók: ");
            foreach (DictionaryEntry valtozo in Environment.GetEnvironmentVariables())
            {
                Console.WriteLine("{0} - {1}", valtozo.Key, valtozo.Value);
            }

            Console.WriteLine("Kevert változó kiértékelve: %windir%\\system32");
            Console.WriteLine(Environment.ExpandEnvironmentVariables("%windir%\\system32"));

            Console.ReadKey();
        }
    }
}
