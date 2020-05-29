using System;
using System.Runtime.InteropServices;

namespace pelda_disposable
{
    public class DisposePelda : IDisposable
    {
        //disposable tag
        private SafeHandle handle;
        private bool disposed = false; //redundáns hívások kivédésére

        public DisposePelda()
        {
            //allokáció itt lenne
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (handle != null)
                    {
                        //disposable tagon dispose hívás
                        handle.Dispose();
                    }
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            //direkt hívás volt
            Dispose(true);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dp = new DisposePelda();
            Console.ReadKey();
        }
    }
}
