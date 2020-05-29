using System;
using System.Text;

namespace pelda_pinvoke2
{
    public class NativeFibonacci: IDisposable
    {
        uint _count;

        public NativeFibonacci(uint limit)
        {
            _count = Native.InitFibonacci(limit);
            StringBuilder sb = new StringBuilder(100);
            long value = Native.GetString(sb, (long)sb.Capacity);
            Console.WriteLine(sb.ToString());
        }

        ~NativeFibonacci()
        {
            Dispose(true);
        }

        public void Kiir()
        {
            Console.WriteLine();
            for (uint i=1; i<_count; i++)
            {
                long eredmeny = Native.GetFibonacci(i);
                Console.Write("{0}, ", eredmeny);
            }
            Console.WriteLine();
        }

        protected void Dispose(bool finalizer)
        {
            if (_count > 0)
            {
                Native.DeleteFibonacci();
                _count = 0;
            }
        }

        public void Dispose()
        {
            Dispose(false);
        }
    }
}
