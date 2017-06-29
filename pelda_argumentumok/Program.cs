using System;

namespace pelda_argumentumok
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Nem elég argumentum!");
                return;
            }

            try
            {
                switch (args[0])
                {
                    case "hello":
                        Console.WriteLine("Hello");
                        break;
                    case "hellow":
                        Console.WriteLine("Hello, {0}!", args[1]);
                        break;
                    default:
                        Console.WriteLine("Ismeretlen argumentum!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba történt: {0}", ex.Message);
            }
            Console.ReadLine();
        }
    }
}
