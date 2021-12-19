using System;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ipc.Common
{
    public sealed class MemFileServer : IServer
    {
        public event EventHandler<ClientDataEventArgs> DataRecieved;
        private ManualResetEvent kill = new ManualResetEvent(false);

        public void Dispose()
        {
            kill.Set();
            kill.Dispose();
        }

        public void Start()
        {
            Task.Factory.StartNew(() =>
            {
                var evt = null as EventWaitHandle;
                if (EventWaitHandle.TryOpenExisting("mmf", out EventWaitHandle handle) == false)
                {
                    evt = new EventWaitHandle(false, EventResetMode.AutoReset, "mmf");
                }

                using (evt)
                using (var file = MemoryMappedFile.CreateOrOpen("memFile", 1024))
                using (var view = file.CreateViewAccessor())
                {

                    var data = new byte[1024];

                    while (WaitHandle.WaitAny(new WaitHandle[] { kill, evt }) == 1)
                    {
                        view.ReadArray(0, data, 0, data.Length);
                        int count = 0;
                        for (int i=0; i<data.Length; i++)
                        {
                            if (data[i] == 0)
                                break;
                            ++count;
                        }
                        var str = Encoding.Default.GetString(data, 0, count);
                        DataRecieved?.Invoke(this, new ClientDataEventArgs(str));
                    }
                }
            });
        }
    }
}
