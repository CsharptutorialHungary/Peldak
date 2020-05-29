using System;
using System.Threading.Tasks;

namespace pelda_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<object> paramTask = (object p) => Console.WriteLine($"task {p}");

            Task.Run(() => Console.WriteLine("hello task"));

            Task.Factory.StartNew(paramTask, "egy");

            var t = new Task<int>(() => { return 42; });
            t.Start();
            Console.WriteLine($"a t task eredménye {t.Result}");
            Console.ReadKey();
        }
    }
}
