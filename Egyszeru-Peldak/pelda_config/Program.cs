using pelda_config.Properties;
using System;

namespace pelda_config
{
    class Program
    {
        static void Main(string[] args)
        {
            int config = Settings.Default.Beallitas;

            Console.WriteLine("Beallitas értéke: {0}", config);

            ++Settings.Default.Beallitas;

            Settings.Default.Save();

            Console.ReadKey();
        }
    }
}
