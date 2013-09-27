using System;
using System.Collections.Generic;
using System.Text;

namespace SoccerScheduler.Elements
{
    abstract class TwoWayList<E> : IList<E>
    {
        IList<E> elements = new List<E>();

        protected abstract void Link(E item);
        protected abstract void Unlink(E item);

#region Implementation
        public int IndexOf(E item)
        {
            return elements.IndexOf(item);
        }

        public void Insert(int index, E item)
        {
            elements.Insert(index, item);
            Link(item);
        }

        public void RemoveAt(int index)
        {
            elements.Remove(elements[index]);
        }

        public E this[int index]
        {
            get
            {
                return elements[index];
            }
            set
            {
                RemoveAt(index);
                Insert(index, value);
            }
        }

        public void Add(E item)
        {
            elements.Add(item);
            Link(item);
        }

        public void Clear()
        {
            foreach (E item in elements)
            {
                elements.Remove(item);
            }
        }

        public bool Contains(E item)
        {
            return elements.Contains(item);
        }

        public void CopyTo(E[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return elements.Count; }
        }

        public bool IsReadOnly
        {
            get { return elements.IsReadOnly; }
        }

        public bool Remove(E item)
        {
            if (elements.Remove(item))
            {
                Unlink(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerator<E> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }
#endregion
    }
}
