using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class ListyIterator<T> : IEnumerable
    {
        private int index;
        private List<T> list;

        public ListyIterator(List<T> components)
        {
            this.list = components;
        }


        public void Print()
        {
            if (list.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }

            Console.WriteLine(list[index]);
        }

        public bool Move()
        {
            if (index < list.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (index < list.Count - 1)
            {
                return true;
            }
            return false;
        }

        public void Create()
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var el in list)
            {
                yield return el;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
