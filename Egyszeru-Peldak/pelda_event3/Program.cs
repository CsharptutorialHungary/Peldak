using System;

namespace pelda_event3
{
    class EventSource
    {
        //Tulajdonség az állapot eléréséhez
        public int Szam { get; private set; }

        public event EventHandler SzamMegvaltozott;

        public EventSource()
        {
            Szam = 0;
        }

        public void DoValami()
        {
            Szam += DateTime.Now.Second;
            //Esemény trigger
            //Előtte null check kell, hogy feliratkozó van-e!
            //EventArgs.Empty-t adunk át, a null érték kerülendő!
            SzamMegvaltozott?.Invoke(this, EventArgs.Empty);
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

        private static void EventSource_SzamMegvaltozott(object sender, EventArgs e)
        {
            var felado = sender as EventSource;
            if (felado!=null)
            {
                //A feladótól kérdezzük le az értéket.
                //Itt az eventHandler csak értesít bennünket.
                Console.WriteLine(felado.Szam);
            }
        }
    }
}
