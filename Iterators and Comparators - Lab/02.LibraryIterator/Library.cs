using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }

        public List<Book> Books { get; set; }
        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int curIndex;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);

            }
            public Book Current => this.books[this.curIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose() {}

            public bool MoveNext()=>++this.curIndex < this.books.Count;
            

            public void Reset()=>this.curIndex = -1;
            
        }
    }
}

