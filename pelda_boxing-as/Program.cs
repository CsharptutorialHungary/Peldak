using System;

namespace pelda_boxing_as
{
    class Program
    {
        static void Main(string[] args)
        {
            int ertek = 11;
            object boxed = ertek;

            if (boxed is int)
            {
                //explicit unbox
                int unboxed = (int)boxed; 
                Console.WriteLine("A csomagolt adat int. Erteke: {0}", unboxed);
            }

            try
            {
                //mivel úgyis hibát dob
                short short_unbox = (short)boxed;
                //ez nem fog lefutni
                Console.WriteLine(short_unbox);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Konvertálási hiba");
            }

            //csak referencia típusok és nullable esetén
            //használható az as operátor!
            short? short_unbox2 = boxed as short?;
            if (short_unbox2 == null)
            {
                Console.WriteLine("Short-ra nem sikerült konvertálni");
                int? un_int = boxed as int?;
                Console.WriteLine("A csomagolt adat int. Erteke: {0}", (int)un_int);
            }
            Console.ReadLine();
        }
    }
}
