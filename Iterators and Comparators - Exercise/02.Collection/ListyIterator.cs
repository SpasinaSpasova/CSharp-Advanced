using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    class ListyIterator<T>: IEnumerable<T>
    {
        private List<T> myList { get; set; }
        private int index { get; set; }
        public ListyIterator(List<T> myList)
        {
            this.myList = myList;
            this.index = 0;
        }

        public bool HasNext()
        {
            if (this.index < myList.Count - 1)
            {
                return true;
            }
            return false;
        }
        public bool Move()
        {
            bool hasNext = this.HasNext();
            if (hasNext)
            {
                this.index++;

            }
            return hasNext;
        }
        public void Print()
        {
            if (this.index >= this.myList.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(myList[this.index]);

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this.myList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
