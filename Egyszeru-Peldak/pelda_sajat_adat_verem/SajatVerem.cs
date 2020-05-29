using System.Collections;
using System.Collections.Generic;

namespace pelda_sajat_adat_verem
{
    public class SajatVerem<T>: IEnumerable<T>
    {
        private List<T> _lista;

        public SajatVerem()
        {
            _lista = new List<T>();
        }

        public void Push(T value)
        {
            _lista.Add(value);
        }

        int Count
        {
            get { return _lista.Count; }
        }

        public T Pop()
        {
            int vege = _lista.Count - 1;
            T ret = _lista[vege];
            _lista.RemoveAt(vege);
            return ret;
        }

        public T Peak()
        {
            int vege = _lista.Count - 1;
            return _lista[vege];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=_lista.Count-1;  i>=0; i--)
            {
                yield return _lista[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
