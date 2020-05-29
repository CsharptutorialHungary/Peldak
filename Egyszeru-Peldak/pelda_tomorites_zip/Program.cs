using System;
using System.IO;
using System.IO.Compression;

namespace pelda_tomorites_zip
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var file = File.Create("test.zip"))
            {
                using (ZipArchive zip = new ZipArchive(file, ZipArchiveMode.Create))
                {
                    ZipArchiveEntry entry = zip.CreateEntry("teszt.txt");
                    entry.LastWriteTime = DateTime.Now;
                    using (var entryStream = entry.Open())
                    {
                        using (var writer = new StreamWriter(entryStream))
                        {
                            writer.Write("teszt");
                        }
                    }
                }
            }
        }
    }
}
