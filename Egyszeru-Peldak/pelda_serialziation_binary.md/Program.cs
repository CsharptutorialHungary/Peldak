using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace pelda_serialziation_binary
{
    [Serializable]
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
        static void Main(string[] args)
        {
            BinaryFormatter serializer = new BinaryFormatter();

            using (MemoryStream teszt = new MemoryStream())
            {
                Osztaly kiirando = new Osztaly
                {
                    Egesz = 42,
                    Tort = 3.1415
                };
                Console.WriteLine("Írás előtt:");
                Console.WriteLine(kiirando);

                serializer.Serialize(teszt, kiirando);

                //visszaállunk a stream elejére
                //az írás után a végén vagyunk
                teszt.Seek(0, SeekOrigin.Begin);

                Console.WriteLine("Olvasás után: ");
                Osztaly beolvasott = (Osztaly)serializer.Deserialize(teszt);
                Console.WriteLine(beolvasott);
            }
            Console.ReadKey();
        }
    }
}
