using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace YAML
{
    //record a ToString() generálása miatt
    internal record class Person
    {
        public string Name { get; init; }
        public int Age { get; init; }
        public float HeightInInches { get; init; }
        public Address Address { get; init; }
    }

    //record a ToString() generálása miatt
    internal record class Address
    {
        public string Street { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string Zip { get; init; }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = new Person
            {
                Name = "Abe Lincoln",
                Age = 25,
                HeightInInches = 6f + 4f / 12f,
                Address =new Address
                {
                    Street = "2720  Sundown Lane",
                    City = "Kentucketsville",
                    State = "Calousiyorkida",
                    Zip = "99978",
                },
            };

            //szerializáció
            ISerializer serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            string yaml = serializer.Serialize(person);
            
            Console.WriteLine(yaml);

            //deszerializáció
            IDeserializer deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();

            Person deserizalized = deserializer.Deserialize<Person>(yaml);

            Console.WriteLine(deserizalized.Name);
        }
    }
}