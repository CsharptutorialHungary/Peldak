using System.Threading;

namespace pelda_thread4
{
    class Program
    {
        static void Main(string[] args)
        {
            var sz = new Szal();
            Thread d = new Thread(new ParameterizedThreadStart(sz.ValameddigSzamol));
            d.Start(3);
        }
    }
}
