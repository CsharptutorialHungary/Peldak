using System.Collections;

namespace pelda_ienumerable
{
    class SzuperCsapat: IEnumerable
    {
        public SzuperCsapat() { } //üres konstruktor

        public IEnumerator GetEnumerator()
        {
            return new SzuperCsapatEnumerator();
        }
    }

    class SzuperCsapatEnumerator : IEnumerator
    {
        private int _index;

        public SzuperCsapatEnumerator()
        {
            //hogy a 0. elem is ki legyen írva
            //mivel a MoveNext() a ciklus elején hívódik!
            _index = -1;
        }

        public object Current
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return "Hannibal";
                    case 1:
                        return "Szépfiú";
                    case 2:
                        return "Murdock";
                    case 3:
                        return "Rosszfiú";
                    default:
                        return null;
                }
            }
        }

        public bool MoveNext()
        {
            _index++;
            return _index < 4;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
