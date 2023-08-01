using System;
using System.IO;
using System.IO.Compression;

namespace pelda_tomorites_gzip
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var file = File.Create("test.br"))
            {
                using (var brotliStream = new BrotliStream(file, CompressionMode.Compress))
                {
                    using (var writer = new StreamWriter(brotliStream))
                    {
                        writer.WriteLine("Ez egy teszt szöveg");
                    }
                }
            }

            using (var file = File.OpenRead("test.br"))
            {
                using (var brotliStream = new BrotliStream(file, CompressionMode.Decompress))
                {
                    using (var reader = new StreamReader(brotliStream))
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
