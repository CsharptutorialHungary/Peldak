using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace pelda_serialziation_xml
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
            XmlSerializer serializer = new XmlSerializer(typeof(Osztaly));

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

                Console.WriteLine("XML adat:\n");
                using (var reader = new StreamReader(teszt, Encoding.UTF8, false, 1024, true))
                {
                    Console.WriteLine(reader.ReadToEnd());
                }

                //visszaállunk ismét a stream elejére
                teszt.Seek(0, SeekOrigin.Begin);

                Console.WriteLine("\nOlvasás után: ");
                Osztaly beolvasott = (Osztaly)serializer.Deserialize(teszt);
                Console.WriteLine(beolvasott);
            }
            Console.ReadKey();
        }
    }
}
