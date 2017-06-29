using System;

namespace pelda_generikus
{
    class Generikus<T> where T : struct
    {
        private T valtozo;

        //a konstruktor privát jelen esetben, mivel
        //a konstruktorok nem lehetnek generikusak!
        private Generikus() {}

        public static Generikus<T> Letrehoz(T parameter)
        {
            Generikus<T> vissza = new Generikus<T>();
            vissza.valtozo = parameter;
            return vissza;
        }

        public override string ToString()
        {
            return string.Format("valtozo tárolt típusa: {0}, Érteke: {1}",
                                  valtozo.GetType().Name, valtozo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Generikus<int> teszt1 = Generikus<int>.Letrehoz(22);
            Generikus<double> teszt2 = Generikus<double>.Letrehoz(33.2);
            Generikus<char> teszt3 = Generikus<char>.Letrehoz('A');
            //az alábbi hibát fog dobni, mert a string osztály!
            //Generikus<string> teszt4 = Generikus<string>.Letrehoz("Teszt");
            Console.WriteLine(teszt1);
            Console.WriteLine(teszt2);
            Console.WriteLine(teszt3);
            Console.ReadKey();
        }
    }
}
