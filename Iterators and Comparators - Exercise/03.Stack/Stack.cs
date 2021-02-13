using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> myStack { get; set; }

        public Stack()
        {
            this.myStack = new List<T>();
        }

        public void Push(T element)
        {

            this.myStack.Add(element);

        }
        public T Pop()
        {
            if (this.myStack.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }
            int index = this.myStack.Count - 1;
            T element = this.myStack[index];
            this.myStack.RemoveAt(index);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.myStack.Count - 1; i >= 0; i--)
            {
                yield return this.myStack[i];

            }
          
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
