using System;
using System.Threading;
using System.Threading.Tasks;

namespace pelda_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Task(() => Thread.Sleep(TimeSpan.FromSeconds(2)));
            t.Start();
            t.Wait();
            Console.WriteLine(t.Status);
        }
    }
}
