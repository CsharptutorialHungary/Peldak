using System;
using System.IO;
using System.Text;

namespace pelda_binaris_fajlkezeles2
{
    public class Osztaly
    {
        public int Egesz { get; set; }
        public double Tort { get; set; }

        public override string ToString()
        {
            return $"Egesz: {Egesz}, Tort: {Tort}";
        }
    }

    class Program
    {
        private static void Kiir(BinaryWriter target, Osztaly peldany)
        {
            target.Write(peldany.Egesz);
            target.Write(peldany.Tort);
        }

        private static Osztaly Beolvas(BinaryReader source)
        {
            return new Osztaly
            {
                Egesz = source.ReadInt32(),
                Tort = source.ReadDouble(),
            };
        }

        static void Main(string[] args)
        {
            using (MemoryStream teszt = new MemoryStream())
            {
                Osztaly kiirando = new Osztaly
                {
                    Egesz = 42,
                    Tort = 3.1415
                };
                Console.WriteLine("Írás előtt:");
                Console.WriteLine(kiirando);
                using (BinaryWriter iro = new BinaryWriter(teszt, Encoding.UTF8, true))
                {
                    Kiir(iro, kiirando);
                }

                //visszaállunk a stream elejére
                //az írás után a végén vagyunk

                Console.WriteLine("Olvasás után: ");

                teszt.Seek(0, SeekOrigin.Begin);
                using (BinaryReader olvaso = new BinaryReader(teszt, Encoding.UTF8, true))
                {
                    Osztaly beolvasott = Beolvas(olvaso);
                    Console.WriteLine(beolvasott);
                }
            }
            Console.ReadKey();
        }
    }
}
