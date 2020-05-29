using System;
using System.Threading.Tasks;

namespace pelda_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => Console.WriteLine("hello task"));
            Console.ReadKey();
        }
    }
}
