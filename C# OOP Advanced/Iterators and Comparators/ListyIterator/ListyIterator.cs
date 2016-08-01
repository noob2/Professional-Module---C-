using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    internal class ListyIterator<T>: IEnumerable<T>
    {
        private readonly List<T> items;

        private int currentIndex;

        private int Count => items.Count;

        public ListyIterator()
        {
            this.items = new List<T>();
            this.currentIndex = 0;
        }

        public void Add(T item)
        {
            this.items.Add(item);
        }

        public bool Move()
        {
            if (currentIndex >= this.Count - 1) return false;
            currentIndex++;
            return true;
        }

        public bool HasNext()
        {
            return currentIndex < this.Count - 1;
        }

        public void Print()
        {
            if (this.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            Console.WriteLine(this.items[currentIndex]);
        }

        public void PrintAll()
        {
            foreach (var item in items)
            {
                Console.Write(item+" ");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
