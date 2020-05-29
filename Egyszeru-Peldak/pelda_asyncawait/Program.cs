using System;
using System.Threading.Tasks;

namespace pelda_asyncawait
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThingsAsync();
            Console.ReadKey();
        }

        private static async Task PrintCurrentTimeAsync()
        {
            Console.WriteLine(DateTime.Now);
            await Task.Delay(2000);
            Console.WriteLine(DateTime.Now);
        }

        private async static void DoThingsAsync()
        {
            await PrintCurrentTimeAsync();
        }
    }
}
