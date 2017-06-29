using System;

namespace pelda_property
{
    class Property
    {
        private int _adattag;

        public int Adattag
        {
            get { return _adattag; }
            set
            {
                if (value > 60000) _adattag = 60000;
                else _adattag = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pelda = new Property();
            pelda.Adattag = 48000;
            Console.WriteLine(pelda.Adattag);
            pelda.Adattag = 1200000;
            Console.WriteLine(pelda.Adattag);
            Console.ReadKey();
        }
    }
}
