using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stack
{
    class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public Stack()
        {
            this.stack = new List<T>();
        }

        public void Push(T item)
        {
            stack.Add(item);
        }

        public void Pop()
        {
            if (stack.Count != 0)
            {
                stack.RemoveAt(stack.Count - 1);
            }
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
