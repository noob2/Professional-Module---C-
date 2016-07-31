using System;

namespace Custom_List
{
    public class CustomList<T> where T : IComparable<T>
    {
        private int InitialCapacity = 16;
        private T[] elements;
        private int count;

        public CustomList()
        {
            this.elements = new T[InitialCapacity];
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }

            private set
            {
                count = value;
            }
        }


        public void Add(T element)
        {
            if (this.count + 1 >= this.elements.Length)
            {
                Resize();
            }
            this.elements[this.Count] = element;
            Count++;
        }

        public T Remove(int index)
        {
            T element = this.elements[index];
            for (int i = index; i < this.Count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[Count - 1] = default(T);
            this.Count--;

            return default(T);
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.Count)
                {
                    throw new IndexOutOfRangeException("index outside of array ex");
                }
                return this.elements[index];
            }
        }

        public bool Contains(T element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            T temp = this.elements[index1];
            this.elements[index1] = this.elements[index2];
            this.elements[index2] = temp;
        }

        public int CountGreatherThan(T element)
        {
            int count = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public T Max()
        {
            T maxItem = default(T);

            if (this.Count == 0)
            {
                throw new InvalidOperationException("0 elements have no max element");
            }

            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(maxItem) > 0)
                {
                    maxItem = this.elements[i];
                }
            }
            return maxItem;
        }

        public T Min()
        {
            T minItem = default(T);

            if (this.Count == 0)
            {
                throw new InvalidOperationException("0 elements have no max element");
            }

            for (int i = 0; i < this.Count; i++)
            {
                if (this.elements[i].CompareTo(minItem) < 0)
                {
                    minItem = this.elements[i];
                }
            }
            return minItem;
        }

        private void Resize()
        {
            int currentLength = this.elements.Length;
            T[] newElements = new T[currentLength * 2];
            Array.Copy(this.elements, newElements, currentLength);
            this.elements = newElements;
        }
    }
}
