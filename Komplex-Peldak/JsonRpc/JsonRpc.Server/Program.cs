using System;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace JsonRpc.Server
{
    internal class Api
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    public static class Program
    {
        public static async Task ServeOneConnectionAsync()
        {
            var server = new NamedPipeServerStream("rpcPipe",
                                    PipeDirection.InOut,
                                    NamedPipeServerStream.MaxAllowedServerInstances,
                                    PipeTransmissionMode.Byte,
                                    PipeOptions.Asynchronous);

            await server.WaitForConnectionAsync();
            var rpc = StreamJsonRpc.JsonRpc.Attach(server, new Api());
            await rpc.Completion;
        }

        public static async Task Main(string[] args)
        {
            Console.WriteLine("Server running. Press CTRL+C to exit");

            while (true)
            {
                await ServeOneConnectionAsync();
            }
        }
    }
}