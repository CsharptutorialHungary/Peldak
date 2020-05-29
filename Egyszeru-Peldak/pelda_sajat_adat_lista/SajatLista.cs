using System;
using System.Collections;
using System.Collections.Generic;

namespace pelda_sajat_adat_lista
{
    //Saját adatszerkezet esetén is érdemes implementálni az
    //ICollection<T> felületet.
    public class SajatLista<T> : ICollection<T>, IList<T>
    {
        private T[] _array;

        //alap konstruktor
        public SajatLista()
        {
            _array = new T[1];
            Count = 0;
        }

        //optimalizált allokáló konstruktor
        public SajatLista(int count)
        {
            _array = new T[count];
            Count = 0;
        }

        public T this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }

        public int Count
        {
            get;
            private set;
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public void Add(T item)
        {

            if (Count + 1 < _array.Length)
            {
                //van elég elemnek hely
                Count += 1;
                _array[Count - 1] = item;
            }
            else
            { 
                //nincs elég hely, ezért allokálunk töbnek helyet
                T[] newArray = new T[_array.Length * 2];
                Array.Copy(_array, 0, newArray, 0, Count);
                Count += 1;
                newArray[Count - 1] = item;
                _array = newArray;
            }
        }

        public void Clear()
        {
            Array.Clear(_array, 0, Count);
        }

        public bool Contains(T item)
        {
            return Array.IndexOf(_array, item) != -1;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Array.Copy(_array, 0, array, arrayIndex, Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=0; i<Count; i++)
            {
                yield return _array[i];
            }
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(_array, item);
        }

        public void Insert(int index, T item)
        {
            if (Count + 1 > _array.Length)
            {
                T[] newArray = new T[_array.Length * 2];
                Array.Copy(_array, 0, newArray, 0, Count);
                _array = newArray;
            }
            Count += 1;
            Array.Copy(_array, index, _array, index + 1, Count - index);
            _array[index] = item;
        }

        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            Count--;
            if (index < Count)
            {
                Array.Copy(_array, index + 1, _array, index, Count - index);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
