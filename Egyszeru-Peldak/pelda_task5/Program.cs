using System;
using System.Threading;
using System.Threading.Tasks;

namespace pelda_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Task(() => Thread.Sleep(TimeSpan.FromSeconds(2)));
            t.Start();
            t.Wait(500);
            Console.WriteLine(t.Status);
        }
    }
}
