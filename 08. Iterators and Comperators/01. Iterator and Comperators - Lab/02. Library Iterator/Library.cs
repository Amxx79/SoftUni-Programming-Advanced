using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>();
            this.books = books.ToList();
        }


        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        private class LibraryIterator : IEnumerator<Book>
        {
            private int iterator = -1;
            private List<Book> books;

            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }

            public Book Current => books[iterator];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                iterator++;
                return iterator < books.Count;
            }

            public void Reset()
            {
                iterator = -1;
            }

            public void Dispose()
            {
            }
        }
    }
}