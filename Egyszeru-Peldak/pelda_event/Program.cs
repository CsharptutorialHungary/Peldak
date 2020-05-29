using System;

namespace pelda_event
{
    //kezelő delegate
    delegate void SzamValtozott(int ujszam);

    class EventSource
    {
        private int _szam;

        public event SzamValtozott SzamMegvaltozott;

        public EventSource()
        {
            _szam = 0;
        }

        public void DoValami()
        {
            _szam += DateTime.Now.Second;
            //Esemény trigger
            //Előtte null check kell, hogy feliratkozó van-e!
            SzamMegvaltozott?.Invoke(_szam);
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

        private static void EventSource_SzamMegvaltozott(int ujszam)
        {
            Console.WriteLine(ujszam);
        }
    }
}
