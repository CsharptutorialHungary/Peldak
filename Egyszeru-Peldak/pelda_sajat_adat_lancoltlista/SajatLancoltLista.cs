using System.Collections;
using System.Collections.Generic;

namespace pelda_sajat_adat_lancoltlista
{
    public class SajatLancoltLista<T>: IEnumerable<T>
    {
        public ListaElem<T> Start { get; private set; }
        public ListaElem<T> End { get; private set; }

        public void Add(T value)
        {
            var next = new ListaElem<T> { Value = value };

            // még üres a lista
            if (Start == null)
            {
                Start = next;
                End = next;
            }
            // már van elem a listában
            else
            {
                End.Next = next;
                End = next;
            }
        }

        private bool Equals(T value, T other)
        {
            if (ReferenceEquals(value, other)) return true;
            else return value.Equals(other);
        }

        public bool Remove(T value)
        {
            ListaElem<T> previous = null;
            ListaElem<T> current = Start;

            while (current != null)
            {
                if (Equals(current.Value, value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            End = previous;
                        }
                    }
                    else
                    {
                        Start = Start.Next;
                        if (Start == null)
                        {
                            End = null;
                        }
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }

            return false;
        }

        public bool Contains(T value)
        {
            var current = Start;

            while (current != null)
            {
                if (Equals(current.Value,value))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Start;

            while (current != null)
            {
                var retval = current.Value;
                current = current.Next;
                yield return retval;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
