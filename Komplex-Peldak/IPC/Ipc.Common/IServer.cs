using System;

namespace Ipc.Common
{
    internal interface IServer : IDisposable
    {
        void Start();

        event EventHandler<ClientDataEventArgs> DataRecieved;
    }
}
