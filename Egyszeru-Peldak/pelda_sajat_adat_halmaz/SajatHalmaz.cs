using System;
using System.Collections;
using System.Collections.Generic;

namespace pelda_sajat_adat_halmaz
{
    public class SajatHalmaz<T>: ICollection<T>
    {
        private T[] _array;

        private int CalculateIndex(T item)
        {
            return Math.Abs(item.GetHashCode() % _array.Length);
        }

        public SajatHalmaz(int meret)
        {
            _array = new T[meret];
        }

        public int Count
        {
            get { return _array.Length; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(T item)
        {
            int index = CalculateIndex(item);
            _array[index] = item;
        }

        public void Clear()
        {
            for (int i=0; i<_array.Length; i++)
            {
                _array[i] = default(T);
            }
        }

        public bool Contains(T item)
        {
            int index = CalculateIndex(item);
            if (_array[index] == null)
                return false;
            return 
                _array[index].Equals(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_array, 0, array, arrayIndex, Count);
        }

        public bool Remove(T item)
        {
            int index = CalculateIndex(item);
            _array[index] = default(T);
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _array.GetEnumerator();
        }
    }
}
