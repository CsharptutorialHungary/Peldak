using System.Diagnostics;

class Program
{
    // a volatile tiltja a compiler optimalizaciot
    private static volatile bool volatileStop = false;
    private static bool nonVolatileStop = false;

    static void Main()
    {
        Thread threadVolatile = new Thread(VolatileWorker);
        threadVolatile.Start();
        
        volatileStop = true;
        Thread.Sleep(100);

        var sw = new Stopwatch();
        sw.Start();
        threadVolatile.Join();
        sw.Stop();
        Console.WriteLine(sw.Elapsed.TotalMicroseconds);
        sw.Reset();

        volatileStop = false;

        Thread threadNonVolatile = new Thread(NonVolatileWorker);
        threadNonVolatile.Start();
        nonVolatileStop = true;
        Thread.Sleep(100);

        sw.Start();
        threadNonVolatile.Join();
        sw.Stop();
        Console.WriteLine(sw.Elapsed.TotalMicroseconds);
    }

    static void VolatileWorker()
    {
        while (!volatileStop)
        {
            // ugyan üres ciklus, de mivel a volatileStop
            // volatile, ezért a fordító nem szedi ki
            // ezt az üres ciklust
        }
        Console.WriteLine("Worker with volatile: Stopped.");
    }

    static void NonVolatileWorker()
    {
        while (!nonVolatileStop)
        {
            // mivel nem volatile a nonVolatileStop
            // ezért ezt az üres ciklust kioptimalizálja
            // a fordító
        }
        Console.WriteLine("Worker without volatile: Stopped.");
    }
}
