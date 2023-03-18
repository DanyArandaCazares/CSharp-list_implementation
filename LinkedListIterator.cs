using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_list_CSharp
{
    internal class LinkedListIterator<T>:Iterator<T>
    {
        private Node<T> currentNode;

        public LinkedListIterator(Node<T> head)
        {
            currentNode = head;
        }
        public bool hasNext()
        {
            return currentNode.next != null;
        }

        public T next()
        {
            T data = currentNode.data;

            currentNode = currentNode.next;

            return data;
        }
    }
}
