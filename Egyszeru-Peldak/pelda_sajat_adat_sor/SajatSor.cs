using System.Collections;
using System.Collections.Generic;

namespace pelda_sajat_adat_sor
{
    public class SajatSor<T>: IEnumerable<T>
    {
        private List<T> _lista;

        public SajatSor()
        {
            _lista = new List<T>();
        }

        public void Enqueue(T item)
        {
            _lista.Add(item);
        }

        public T Dequeue()
        {
            T item = _lista[0];
            _lista.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            return _lista[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=_lista.Count-1; i>=0; i--)
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
