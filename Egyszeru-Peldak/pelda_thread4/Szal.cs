using System;

namespace pelda_thread4
{
    class Szal
    {
        public void ValameddigSzamol(object meddig)
        {
            var eddig = (int)meddig;
            Console.Write($"\n Elszámolok {eddig}-ig!");
            for (int i = 0; i < eddig; i++)
            {
                Console.Write('.');
                Thread.Sleep(1000);
            }
            Console.Write($"\n {eddig}!");
        }
    }
}
