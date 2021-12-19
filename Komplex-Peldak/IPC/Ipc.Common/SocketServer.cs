using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Ipc.Common
{
    public sealed class SocketServer : IServer
    {
        private UdpClient _server;

        public event EventHandler<ClientDataEventArgs> DataRecieved;

        public SocketServer()
        {
            _server = new UdpClient(63000);
        }

        public void Dispose()
        {
            if (_server != null)
            {
                _server.Close();
                _server.Dispose();
                _server = null;
            }
        }

        public void Start()
        {
            Task.Factory.StartNew(() =>
            {
                var ip = new IPEndPoint(IPAddress.Any, 0);
                while (true)
                {
                    var bytes = _server.Receive(ref ip);
                    var data = Encoding.UTF8.GetString(bytes);

                    if (DataRecieved != null)
                    {
                        DataRecieved?.Invoke(this, new ClientDataEventArgs(data));
                    }
                }
            });
        }
    }
}
