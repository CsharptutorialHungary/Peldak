using System;
using System.Threading.Tasks;

namespace pelda_asyncawait3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await EzEgyTaskAsync();
            var ti = await EzEgyTaskOfIntAsync();
            Console.WriteLine(ti);
            Console.ReadKey();
        }

        static async Task EzEgyTaskAsync()
        {
            await Task.Delay(100);
        }

        static async Task<int> EzEgyTaskOfIntAsync()
        {
            await Task.Delay(100);
            return 42;
        }
    }
}
