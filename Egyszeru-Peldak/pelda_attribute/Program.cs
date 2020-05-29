using System;
using System.Linq;

namespace pelda_attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var TesztOsztaly = new TesztOsztaly();
            Type osztalyType = TesztOsztaly.GetType();

            var attributum = (from attribute in
                                  osztalyType.GetCustomAttributes(typeof(CreationDateAttribute), false)
                              select
                                  attribute as CreationDateAttribute).FirstOrDefault();

            TimeSpan age = DateTime.Now.Date - attributum.CreationDate;

            Console.WriteLine("Az osztály ennyi idős: {0} nap", age.TotalDays);

            Console.ReadKey();

        }
    }
}
