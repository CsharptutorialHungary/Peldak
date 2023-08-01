using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace XMLXsd
{
    public class Book
    {
        [XmlElement("author")]
        public string Author { get; set; }

        [XmlElement("publicationYear")]
        public int PublicationYear { get; set; }

        [XmlAttribute("title")]
        public string Title { get; set; }
    }

    public class Books
    {
        [XmlElement("book")]
        public Book[] BookArray { get; set; }
    }

    public static class Program
    {
        private static bool TryValidate(string xmlPath, string xsdPath, out string issues)
        {
            StringBuilder issuesBuilder = new StringBuilder();
            bool valid = true;

            var schemaSet = new XmlSchemaSet();
            schemaSet.Add(null, xsdPath);

            var xmlReaderSettings = new XmlReaderSettings
            {
                ValidationType = ValidationType.Schema,
                Schemas = schemaSet
            };
            xmlReaderSettings.ValidationEventHandler += (s, e) =>
            {
                if (e.Severity == XmlSeverityType.Warning)
                {
                    issuesBuilder.AppendLine($"Warning: {e.Message}");
                }
                else if (e.Severity == XmlSeverityType.Error)
                {
                    issuesBuilder.AppendLine($"Error: {e.Message}");
                    valid = false;
                }
            };

            using (var xmlSteam = File.OpenRead(xmlPath))
            {
                var reader = XmlReader.Create(xmlSteam, xmlReaderSettings);
                while (reader.Read());
            }

            issues = issuesBuilder.ToString();
            return valid;
        }

        public static void Main(string[] args)
        {
            string issues;
            if (TryValidate("books.xml", "books.xsd", out issues))
            {
                using (var xmlStream = File.OpenRead("books.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Books), new XmlRootAttribute("books"));
                    var books = (Books)xs.Deserialize(xmlStream);
                    Console.WriteLine("Count of Books: {0}", books.BookArray.Length);
                }
            }
            Console.WriteLine("XML issues:");
            Console.WriteLine(issues);
        }
    }
}