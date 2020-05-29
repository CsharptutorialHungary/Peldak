using System;
using System.IO;
using System.Text;

namespace pelda_szoveges_fajlkezeles
{
    namespace pelda_binaris_fajlkezeles2
    {
        class Program
        {
            static void Main(string[] args)
            {
                using (MemoryStream teszt = new MemoryStream())
                {
                    using (StreamWriter iro = new StreamWriter(teszt, Encoding.UTF8, 1024, true))
                    {
                        iro.WriteLine("Ez egy sor amit beírunk");
                        iro.WriteLine("Ez meg egy másik sor");
                        iro.WriteLine("Ez meg a harmadik");
                    }

                    //visszaállunk a stream elejére
                    //az írás után a végén vagyunk

                    Console.WriteLine("Olvasás után: ");
                    teszt.Seek(0, SeekOrigin.Begin);

                    using (StreamReader olvaso = new StreamReader(teszt, Encoding.UTF8, false, 1024, true))
                    {
                        string sor = null;
                        while ((sor = olvaso.ReadLine()) != null)
                        {
                            Console.WriteLine(olvaso.ReadLine());
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
