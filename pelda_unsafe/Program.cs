using System;

namespace pelda_unsafe
{
    class Program
    {
        static unsafe void Negyzet(int* p)
        {
            *p *= *p;
        }

        unsafe static void Main()
        {
            int i = 5;
            //& érték átadás, mint C esetén
            Negyzet(&i);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
