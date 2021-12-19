using System;

namespace Ipc.Common
{
    [Serializable]
    public sealed class ClientDataEventArgs : EventArgs
    {
        public ClientDataEventArgs(string data)
        {
            Data = data;
        }

        public string Data { get; }
    }
}
