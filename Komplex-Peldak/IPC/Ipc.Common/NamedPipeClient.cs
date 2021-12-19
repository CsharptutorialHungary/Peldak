using System.IO;
using System.IO.Pipes;

namespace Ipc.Common
{
    public sealed class NamedPipeClient : IClient
    {
        public void Send(string data)
        {
            using (var client = new NamedPipeClientStream(".", "namedpipe", PipeDirection.Out))
            {
                client.Connect();
                using (var writer = new StreamWriter(client))
                {
                    writer.WriteLine(data);
                }
            }
        }
    }
}
