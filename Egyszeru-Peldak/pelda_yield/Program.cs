﻿using System;

namespace pelda_yield
{
    class Program
    {
        static void Main(string[] args)
        {
            var ATeam = new SzuperCsapat();
            Console.WriteLine("A szuper csapat tagjai:");
            foreach (var tag in ATeam)
            {
                Console.WriteLine(tag);
            }
            Console.ReadKey();
        }
    }
}
