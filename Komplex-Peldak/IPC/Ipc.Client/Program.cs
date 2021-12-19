using Ipc.Common;

namespace Ipc.Client
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var socketClient = new SocketClient();
            socketClient.Send("Hello from Sockets");

            var memClient = new MemFileClient();
            memClient.Send("Hello from Memory Mapped Files");

            var pipeClient = new NamedPipeClient();
            pipeClient.Send("Hello from Named pipe");
        }
    }
}