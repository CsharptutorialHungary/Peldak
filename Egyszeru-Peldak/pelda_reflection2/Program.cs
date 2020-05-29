using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace pelda_reflection2
{
    class Program
    {
        static void Main(string[] args)
        {
            //jelenlegi szerelvény lekérése
            Assembly current = typeof(IModule).Assembly;

            //Minden IModule felületet megvalósító típus lekérése
            //Ami osztály
            var modules = from type in current.GetTypes()
                          where
                             typeof(IModule).IsAssignableFrom(type)
                             && type.IsClass
                             && !type.IsAbstract
                          select
                            type;

            //Lista a példányok tárolására
            List<IModule> instances = new List<IModule>();

            foreach (var module in modules)
            {
                //Példányosítás paraméter nélküli konstruktorral
                IModule instance = Activator.CreateInstance(module) as IModule;
                if (instance != null)
                {
                    //Példány tárolása
                    instances.Add(instance);
                }
            }

            Console.WriteLine("Parncsok: {0}", instances.Count);

            //Példányok közül megadott névvel rendelkező keresése, majd a Run metódusának hívása
            do
            {
                Console.Write("Command: ");
                var cmd = Console.ReadLine();

                var selected = instances.Where(i => i.Name == cmd).FirstOrDefault();
                if (selected != null)
                {
                    selected.Run();
                }
                else if (cmd == "Exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nem található: {0}", cmd);
                }
            }
            while (true);

        }
    }
}
