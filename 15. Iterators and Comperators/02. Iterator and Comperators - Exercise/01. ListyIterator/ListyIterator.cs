using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T>
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
    }
}
