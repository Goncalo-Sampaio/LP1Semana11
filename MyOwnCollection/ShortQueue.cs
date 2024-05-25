using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyOwnCollection
{
    public class ShortQueue<T> : ICollection<T>
    {
        private List<T> innerCollection;
        private int maxCapacity;
        public int Count => innerCollection.Count;
        public bool IsReadOnly
        {
            get { return false; }
        }

        public ShortQueue()
        {
            innerCollection = new List<T>();
            maxCapacity = 5;
        }

        public ShortQueue(int capacity)
        {
            innerCollection = new List<T>();
            maxCapacity = capacity;
        }

        public void Add(T item)
        {

            if (Count == maxCapacity)
            {
                innerCollection.RemoveAt(innerCollection.Count - 1);
                innerCollection.Add(item);
            }
            else innerCollection.Add(item);
        }

        public void Clear()
        {
            innerCollection.Clear();
        }

        public bool Contains(T item)
        {
            return innerCollection.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            for (int i = arrayIndex; i > Count; i++)
            {
                array[i] = innerCollection[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {

            for (int i = 0; i < Count; i++)
            {
                yield return innerCollection[i];
            }
        }

        public bool Remove(T item)
        {
            int numbOfItem = 0;
            if (Contains(item))
            {
                numbOfItem = innerCollection.Count(i => i.Equals(item));
                if (numbOfItem > 1)
                {
                    int indexToRemove = Count;
                    foreach (T itemToRemove in innerCollection)
                    {
                        if (itemToRemove.Equals(item))
                        {
                            if (innerCollection.IndexOf(itemToRemove) < indexToRemove)
                            {
                                indexToRemove = innerCollection.IndexOf(itemToRemove);
                            }
                        }
                    }
                    innerCollection.RemoveAt(indexToRemove);
                    return true;
                }
                else innerCollection.RemoveAt(innerCollection.IndexOf(item));
                return true;
            }
            else return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}