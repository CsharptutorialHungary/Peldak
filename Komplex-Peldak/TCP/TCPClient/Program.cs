using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using TCPCommon;

namespace TCPClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TcpClient client = new TcpClient();
            try
            {
                await client.ConnectAsync(IPAddress.Parse("127.0.0.1"), 9210);
                using (var stream = client.GetStream())
                {
                    RequestMessage request = new RequestMessage
                    {
                        Darab = 5
                    };

                    MessageSerializer.SerializeTo(stream, request);

                    await Task.Delay(100);

                    Message response = MessageSerializer.SerializeFrom<Message>(stream);

                    WriteResponse(response);
                }
            }
            finally
            {
                Console.WriteLine("Client done. Press a key to exit");
                Console.ReadKey();
                client.Close();
            }
        }

        private static void WriteResponse(Message response)
        {
            Console.WriteLine(response.ResponseTime);
            Console.WriteLine();
            Console.WriteLine(string.Join(",", response.Szamok));
        }
    }
}
