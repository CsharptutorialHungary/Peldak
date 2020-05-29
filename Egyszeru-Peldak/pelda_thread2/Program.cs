using System.Threading;

namespace pelda_thread2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sz = new Szal();
            Thread t = new Thread(new ThreadStart(sz.TizigSzamol));
            t.Start();
        }
    }
}
