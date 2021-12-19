using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;

namespace Ipc.Common
{
    public class MemFileClient : IClient
    {
        public void Send(string data)
        {
            if (EventWaitHandle.TryOpenExisting("mmf", out EventWaitHandle handle) == false)
            {
                handle = new EventWaitHandle(false, EventResetMode.AutoReset, "mmf");
            }

            using (handle)
            using (var file = MemoryMappedFile.CreateOrOpen("memFile", 1024))
            using (MemoryMappedViewAccessor view = file.CreateViewAccessor())
            {
                var bytes = Encoding.Default.GetBytes(data);
                view.WriteArray(0, bytes, 0, bytes.Length);
                handle.Set();
            }
        }
    }
}
