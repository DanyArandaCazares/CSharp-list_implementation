using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_list_CSharp
{
    internal class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node<T> previous;

        public Node()
        {
            next = null;
            previous = null;
        }
    }
}
