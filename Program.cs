using System;
using System.IO;
using System.IO.Compression;

namespace pelda_tomorites_gzip
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var file = File.Create("test.txt"))
            {
                using (var gZipStream = new GZipStream(file, CompressionMode.Compress))
                {
                    using (var writer = new StreamWriter(gZipStream))
                    {
                        writer.WriteLine("Ez egy teszt szöveg");
                    }
                }
            }

            using (var file = File.OpenRead("test.txt"))
            {
                using (var gZipStream = new GZipStream(file, CompressionMode.Decompress))
                {
                    using (var reader = new StreamReader(gZipStream))
                    {
                        Console.WriteLine(reader.ReadLine());
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
