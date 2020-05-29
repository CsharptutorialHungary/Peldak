using MEF.API;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;

namespace MEF
{
    public class Runner
    {
        //tároló a moduloknak
        //Az ImportMany jelzi a MEF-nek, hogy egy kolleckiót kell feltöltenie
        [ImportMany(typeof(IModule))]
        private IEnumerable<IModule> _modules;

        private IHost _host;

        public void DoLoad()
        {
            //Katalógusokat tároló katalógus
            var catalog = new AggregateCatalog();
            //Futtató szerelvényből típusok keresése, amik Export atribútummal meg vannak jelölve
            catalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));
            //Adott mappából szerelvények betöltése és az Export atribútummal megjelölt típusok betöltése
            catalog.Catalogs.Add(new DirectoryCatalog(Environment.CurrentDirectory));
            //Kompozíciós konténer létrehozása. A betöltés itt valósul meg.
            CompositionContainer container = new CompositionContainer(catalog);

            //IHost elérhetőségének tesztelése.
            _host = container.GetExportedValue<IHost>();

            if (_host == null)
            {
                Console.WriteLine("Nincs host. Valami gond van");
                Environment.Exit(-1);
            }

            //A modulok betöltése
            container.ComposeParts(this);
            //A modulok számára az IHost függőség kielégítése
            container.SatisfyImportsOnce(this);
        }

        //Példányok közül megadott névvel rendelkező keresése, majd a Run metódusának hívása
        public void Run()
        {
            do
            {
                Console.Write("Command: ");
                var cmd = Console.ReadLine();

                var selected = _modules.FirstOrDefault(i => i.Name == cmd);
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
                    _host.WriteLine("Nem található: {0}", cmd);
                }
            }
            while (true);
        }
    }
}
