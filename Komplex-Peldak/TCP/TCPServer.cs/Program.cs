using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using TCPCommon;

namespace TCPServer.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint localhost = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9210);
            TcpListener server = new TcpListener(localhost);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            try
            {
                server.Start();

                Task.Run(() => ServerTask(server, tokenSource.Token));

                Console.WriteLine("Server running. Press a key to exit");
                Console.ReadKey();
            }
            finally
            {
                tokenSource.Cancel();
                server.Stop();
            }


        }

        private static async Task ServerTask(TcpListener server, CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                {
                    break;
                }

                TcpClient client = await server.AcceptTcpClientAsync();

                using (var stream = client.GetStream())
                {
                    while (stream.DataAvailable == false)
                    {

                    }

                    RequestMessage processedRequest = MessageSerializer.SerializeFrom<RequestMessage>(stream);

                    if (token.IsCancellationRequested)
                    {
                        break;
                    }

                    Message responseMessage = CreateResponse(processedRequest.Darab);

                    MessageSerializer.SerializeTo(stream, responseMessage);
                }
            }
        }

        private static Message CreateResponse(int darab)
        {
            Message result = new Message
            {
                Szamok = new List<int>(darab)
            };
            Random r = new Random();
            for (int i=0; i<darab; i++)
            {
                result.Szamok.Add(r.Next(0, 1000));
            }
            result.ResponseTime = DateTime.Now;
            return result;
        }
    }
}
