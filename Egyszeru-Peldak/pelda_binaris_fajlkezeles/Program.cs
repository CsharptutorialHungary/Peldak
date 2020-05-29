using System;
using System.IO;

namespace pelda_binaris_fajlkezeles
{
    class Program
    {
        private static void Masol(string forras, string cel)
        {
            try
            {
                using (FileStream src = File.OpenRead(forras))
                {
                    using (FileStream target = File.Create(cel))
                    {
                        byte[] buffer = new byte[32 * 1024];
                        int beolvasott = 0;
                        long atmasolt = 0;
                        do
                        {
                            beolvasott = src.Read(buffer, 0, buffer.Length);
                            target.Write(buffer, 0, beolvasott);
                            atmasolt += beolvasott;
                            Console.WriteLine("Kesz: {0.00:P} \r", (double)atmasolt / src.Length);
                        }
                        while (beolvasott > 0);

                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Forrás: ");
            string forras = Console.ReadLine();
            Console.Write("Cél: ");
            string cel = Console.ReadLine();
            Masol(forras, cel);

            Console.ReadKey();
        }
    }
}
