using System;
using System.Collections;

namespace pelda_delegate
{
    delegate int Modosito(int bemenet);

    class DelegateDemo: IEnumerable
    {
        private int[] _tomb;

        public DelegateDemo()
        {
            _tomb = new int[] { 1, 2, 3, 4, 5 };
        }

        public IEnumerator GetEnumerator()
        {
            return _tomb.GetEnumerator();
        }

        public void Modosit(Modosito m)
        {
            if (m == null) return; // hibavédelem

            for (int i=0; i<_tomb.Length; i++)
            {
                _tomb[i] = m(_tomb[i]);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            DelegateDemo delegateDemo = new DelegateDemo();
            Kiir(delegateDemo);
            delegateDemo.Modosit(negyzet);
            Kiir(delegateDemo);
            delegateDemo.Modosit(Duplaz);
            Kiir(delegateDemo);
            Console.ReadKey();
        }

        private static void Kiir(DelegateDemo delegateDemo)
        {
            Console.WriteLine("Elemek:");
            foreach(var item in delegateDemo)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static int Duplaz(int bemenet)
        {
            return 2 * bemenet;
        }

        private static int negyzet(int bemenet)
        {
            return bemenet * bemenet;
        }
    }
}
