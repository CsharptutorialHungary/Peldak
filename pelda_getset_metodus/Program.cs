using System;

namespace pelda_getset_metodus
{
    class GetSetMetodus
    {
        private int _adattag;

        public int GetAdattag()
        {
            return _adattag;
        }

        public void SetAdattag(int adat)
        {
            if (adat > 60000) _adattag = 60000;
            else _adattag = adat;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pelda = new GetSetMetodus();
            pelda.SetAdattag(48000);
            Console.WriteLine(pelda.GetAdattag());
            pelda.SetAdattag(1200000);
            Console.WriteLine(pelda.GetAdattag());
            Console.ReadKey();
        }
    }
}
