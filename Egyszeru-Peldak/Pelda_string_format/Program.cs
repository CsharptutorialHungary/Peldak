using System;

namespace pelda_string_format
{
    class Program
    {
        static void Main(string[] args)
        {
            int ma = 21;
            int tnap = 18;
            var s = string.Format("Ma {0} fok volt, tegnap pedig {2}", ma, tnap);

            Console.WriteLine(s);

            Console.WriteLine("Így is lehet: {0}, {1}", ma, tnap);
            Console.ReadKey();
        }
    }
}
