using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ipc.Common
{
    internal class JsonRpcServer : IServer
    {
        public event EventHandler<ClientDataEventArgs> DataRecieved;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
    }
}
