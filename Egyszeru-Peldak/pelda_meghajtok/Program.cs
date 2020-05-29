using System;
using System.IO;

namespace pelda_meghajtok
{
    class Program
    {
        static void Main(string[] args)
        {
            var meghajtok = DriveInfo.GetDrives();
            foreach (var m in meghajtok)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Nev: {0}", m.Name);
                Console.WriteLine("Root dir: {0}", m.RootDirectory);
                Console.WriteLine("IsReady: {0}", m.IsReady);
                Console.WriteLine("Tipus: {0,-20}", m.DriveType);
                if (m.IsReady)
                {
                    //ha nem IsReady, akkor nincs benne lemez
                    //vagy nem áll kész további műveletekre
                    Console.WriteLine("Kotetcimke: {0}", m.VolumeLabel);
                    Console.WriteLine("Formatum: {0}", m.DriveFormat);
                    Console.WriteLine("Meret: {0} byte", m.TotalSize);
                    Console.WriteLine("felhasznalhato: {0} byte", m.AvailableFreeSpace);
                    Console.WriteLine("Szabad: {0} byte", m.TotalFreeSpace);
                }
            }
            Console.ReadKey();
        }
    }
}
