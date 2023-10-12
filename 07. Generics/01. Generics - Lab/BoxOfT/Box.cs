using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
         private Stack<T> data;
         public Box()
         {
             data = new Stack<T>();
         }
         
         public int Count
         {
             get { return data.Count; }
         }
         
         public void Add(T element)
         {
             data.Push(element);
         }
         
         public T Remove()
         {
             return data.Pop();
         }
         
         
         
    }
}
