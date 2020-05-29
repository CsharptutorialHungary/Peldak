using System;
using System.Threading;
using System.Threading.Tasks;

namespace pelda_task6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var t = new Task(() => Thread.Sleep(TimeSpan.FromSeconds(2)));
                t.Start();
                t.Wait(500, new CancellationToken(true));
                Console.WriteLine(t.Status);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
