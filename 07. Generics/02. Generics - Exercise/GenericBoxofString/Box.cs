using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{

    public class Box<T>
    {
        public T item;

        public void Add(T item)
        {
            this.item = item;
        }
    }
}
