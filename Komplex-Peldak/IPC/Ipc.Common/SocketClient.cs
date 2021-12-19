using System;
using System.Net.Sockets;
using System.Text;

namespace Ipc.Common
{
    public class SocketClient : IClient
    {
        public void Send(string data)
        {
            using (var client = new UdpClient())
            {
                try
                {
                    client.Connect(string.Empty, 63000);
                    var dataBytes = Encoding.UTF8.GetBytes(data);
                    client.Send(dataBytes, dataBytes.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
