using System;

namespace pelda_environment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLR: {0}", Environment.Version);
            Console.WriteLine("64 bites os: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("64 bites process: {0}", Environment.Is64BitProcess);
            Console.WriteLine("Gépnév: {0}", Environment.MachineName);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("User: {0}", Environment.UserName);
            Console.WriteLine("Mappa: {0}", Environment.CurrentDirectory);
            Console.WriteLine("Parancssor: {0}", Environment.CommandLine);
            Console.WriteLine("CPU szam: {0}", Environment.ProcessorCount);

            Console.ReadKey();
        }
    }
}
