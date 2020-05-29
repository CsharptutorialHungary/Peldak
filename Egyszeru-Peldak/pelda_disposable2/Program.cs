using System;

namespace pelda_disposable2
{
    public class DisposeOs : IDisposable
    {
        private bool disposed = false; //redundáns hívások kivédésére

        public DisposeOs()
        {
            //disposable tagok allokációja
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose hívás a tagokon, mint eddig
                }

                //ide jön a megosztott logika
                disposed = true;
            }
        }

        ~DisposeOs()
        {
            //destruktor indirekt hívással
            Dispose(false);
        }

        public void Dispose()
        {
            //direkt hívás
            Dispose(true);
            //destruktor hívás kezdeményezése
            GC.SuppressFinalize(this);
        }
    }

    public class DisposeLeszarmazott : DisposeOs
    {
        private bool disposed = false; //redundáns hívások kivédésére

        public DisposeLeszarmazott() : base()
        {
            //további Disposable tagok allokációja
        }

        protected override void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    //dispose hívás
                }
                //újabb osztott logika
                disposed = true;
            }
            //őson a dispose hívás.
            base.Dispose(disposing);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var l = new DisposeLeszarmazott();
            Console.ReadKey();
        }
    }
}
