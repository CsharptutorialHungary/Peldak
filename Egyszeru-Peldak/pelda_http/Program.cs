using System;
using System.Net;

namespace pelda_http
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var webClient = new WebClient())
            {
                //Proxy konfigurálása, ha van
                IWebProxy proxy = WebRequest.DefaultWebProxy;
                proxy.Credentials = CredentialCache.DefaultCredentials;
                webClient.Proxy = proxy;

                //publikus IP cím lekérsése
                string ip = webClient.DownloadString("https://api.ipify.org");
                //konvertálás .NET IPAddress osztályba
                IPAddress address = IPAddress.Parse(ip);
                Console.WriteLine("IP: {0}, Family: {1}", address, address.AddressFamily);

                Console.WriteLine("\nHost name:");
                //DNS host név megállapítása a címből
                IPHostEntry entry = Dns.GetHostEntry(address);
                if (entry.AddressList.Length > 0)
                {
                    Console.WriteLine(entry.HostName);
                    Console.WriteLine("Ip adresses:");
                    foreach (IPAddress item in entry.AddressList)
                    {
                        //sikeres találat esetén legalább 
                        //1db ip tartozik egy host névhez
                        Console.WriteLine(item);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
