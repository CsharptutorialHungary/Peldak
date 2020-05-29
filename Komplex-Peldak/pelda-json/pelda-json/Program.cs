using Newtonsoft.Json;
using System;

namespace pelda_json
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
        static void Main(string[] args)
        {
            Osztaly kiirando = new Osztaly
            {
                Egesz = 42,
                Tort = 3.1415
            };
            string json = JsonConvert.SerializeObject(kiirando, Formatting.Indented);

            Console.WriteLine("Json:");
            Console.WriteLine(json);

            Osztaly vissza = JsonConvert.DeserializeObject<Osztaly>(json);

            Console.WriteLine(vissza);
            Console.ReadKey();

        }
    }
}
