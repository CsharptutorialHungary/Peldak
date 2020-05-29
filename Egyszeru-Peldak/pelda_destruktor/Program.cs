using System.Diagnostics;

namespace pelda_destruktor
{
    class Elso
    {
        ~Elso()
        {
            Trace.WriteLine("Első destruktora lefutott");
        }
    }

    class Masodik : Elso
    {
        ~Masodik()
        {
            Trace.WriteLine("Második destruktora lefutott");
        }
    }

    class Harmadik : Masodik
    {
        ~Harmadik()
        {
            Trace.WriteLine("Harmadik destruktora lefutott");
        }
    }

    class Program
    {
        static void Main()
        {
            Harmadik t = new Harmadik();
        }
 
    }
}
