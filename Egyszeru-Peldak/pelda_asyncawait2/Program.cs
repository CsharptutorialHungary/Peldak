using System;
using System.Threading.Tasks;

namespace pelda_asyncawait2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThingsAsync();
            Console.ReadKey();
        }

        static async void DoThingsAsync()
        {
            EzEgyVoidAsync();
            await EzEgyTaskAsync();
            var ti = await EzEgyTaskOfIntAsync();
            Console.WriteLine(ti);
        }

        static async void EzEgyVoidAsync()
        {
            await Task.Delay(100);
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
