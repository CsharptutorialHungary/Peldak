using System;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace JsonRpc.Client
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var client = new NamedPipeClientStream(".",
                                                   "rpcPipe",
                                                   PipeDirection.InOut,
                                                   PipeOptions.Asynchronous);
            await client.ConnectAsync();
            using var rpc = StreamJsonRpc.JsonRpc.Attach(client);
            int sum = await rpc.InvokeAsync<int>("Add", 3, 5);
            Console.WriteLine($"Add(3, 5): {sum}");
            Console.ReadKey();
        }
    }
}