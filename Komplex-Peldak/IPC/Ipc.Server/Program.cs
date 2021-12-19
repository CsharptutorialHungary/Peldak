using Ipc.Common;
using System;

namespace Ipc.Server
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Server running. Start client");
            Console.WriteLine("Press a key to exit app");

            var socketSrv = new SocketServer();
            socketSrv.Start();
            socketSrv.DataRecieved += OnDataRecieve;

            var memFileSrv = new MemFileServer();
            memFileSrv.Start();
            memFileSrv.DataRecieved += OnDataRecieve;

            var pipeSrv = new NamedPipeServer();
            pipeSrv.Start();
            pipeSrv.DataRecieved += OnDataRecieve;

            Console.ReadKey();
            socketSrv.Dispose();
            memFileSrv.Dispose();
        }

        private static void OnDataRecieve(object sender, ClientDataEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
                Console.WriteLine($"{sender.GetType().Name}: {e.Data}");
        }
    }
}