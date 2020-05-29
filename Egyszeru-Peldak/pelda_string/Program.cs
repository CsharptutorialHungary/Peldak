using System;
using System.Diagnostics;
using System.Text;

namespace pelda_string
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "";
            var sb = new StringBuilder();
            var r = new Random();

            Console.WriteLine("100 000 db random karater összefűzése szövegbe");

            Stopwatch watch = Stopwatch.StartNew(); //algoritmusok sebességének mérésére használható osztály
            for (int i=0; i<100000; i++)
            {
                s += (char)r.Next(32, 255);
            }
            watch.Stop();
            var stime = watch.Elapsed.TotalMilliseconds;

            watch = Stopwatch.StartNew();
            for (int i = 0; i < 1000000; i++)
            {
                sb.Append((char)r.Next(32, 255));
            }
            watch.Stop();
            var sbtime = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine("Eddig tartott String-el: {0} ms", stime);
            Console.WriteLine("Eddig tartott StringBuilder-el: {0} ms", sbtime);
            Console.ReadKey();
        }
    }
}
