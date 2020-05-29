using System;

namespace pelda_event2
{
    class SzamEventArgs: EventArgs
    {
        public int Szam { get; }

        public SzamEventArgs(int szam)
        {
            Szam = szam;
        }
    }

    class EventSource
    {
        private int _szam;

        public event EventHandler<SzamEventArgs> SzamMegvaltozott;

        public EventSource()
        {
            _szam = 0;
        }

        public void DoValami()
        {
            _szam += DateTime.Now.Second;
            //Esemény trigger
            //Előtte null check kell, hogy feliratkozó van-e!
            SzamMegvaltozott?.Invoke(this, new SzamEventArgs(_szam));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            EventSource eventSource = new EventSource();
            //Feliratkozás
            eventSource.SzamMegvaltozott += EventSource_SzamMegvaltozott;

            //3 trigger
            eventSource.DoValami();
            eventSource.DoValami();
            eventSource.DoValami();

            Console.ReadKey();

            //leiratkozás
            eventSource.SzamMegvaltozott -= EventSource_SzamMegvaltozott;
        }

        private static void EventSource_SzamMegvaltozott(object sender, SzamEventArgs e)
        {
            Console.WriteLine(e.Szam);
        }
    }
}
