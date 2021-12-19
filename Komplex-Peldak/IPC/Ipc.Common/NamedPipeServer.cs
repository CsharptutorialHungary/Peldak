using System;
using System.IO;
using System.IO.Pipes;
using System.Threading.Tasks;

namespace Ipc.Common
{
    public sealed class NamedPipeServer : IServer
    {
        public event EventHandler<ClientDataEventArgs> DataRecieved;
        private NamedPipeServerStream _server;

        public NamedPipeServer()
        {
            _server = new NamedPipeServerStream("namedpipe", PipeDirection.In);
        }

        public void Dispose()
        {
            _server.Disconnect();
            _server.Dispose();
        }

        public void Start()
        {
            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    _server.WaitForConnection();
                    using (var reader = new StreamReader(_server))
                    {
                        var msg = reader.ReadToEnd();
                        DataRecieved?.Invoke(this, new ClientDataEventArgs(msg));
                    }
                }
            });
        }
    }
}
