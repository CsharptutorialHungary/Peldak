using System;
using System.Threading.Tasks;

namespace pelda_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Task(() => Thread.Sleep(TimeSpan.FromSeconds(2)));
            t.Start();
            while (true)
            {
                Console.WriteLine(t.Status);
                Thread.Sleep(100);
            }
        }
    }
}
