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
        public Library(params Book[] books)
        {
            this.Books = new List<Book>();
            Books = books.ToList();
        }

        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                yield return Books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



    }
}
