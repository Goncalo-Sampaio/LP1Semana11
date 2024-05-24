using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T var1;
        private T var2;
        private T var3;
        public Guarda3()
        {
            var1 = default;
            var2 = default;
            var3 = default;
        }

        public T GetItem(int i)
        {
            if (i == 0) return var1;
            else if (i == 1) return var2;
            else if (i == 2) return var3;
            else throw new IndexOutOfRangeException();
        }

        public void SetItem(int i, T item)
        {
            if (i == 0) var1 = item;
            else if (i == 1) var2 = item;
            else if (i == 2) var3 = item;
            else throw new IndexOutOfRangeException();
        }

        public void Add(T item)
        {
            if (Equals(var1, default(T))) var1 = item;
            else if (Equals(var2, default(T))) var2 = item;
            else if (Equals(var3, default(T))) var3 = item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> list = new List<T>() { var1, var2, var3 };

            for (int i = 0; i < 3; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}