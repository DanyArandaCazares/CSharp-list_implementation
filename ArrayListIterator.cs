using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_list_CSharp
{
    internal class ArrayListIterator<T>:Iterator<T>
    {
        private T[] array;
        private int position;


        public ArrayListIterator(T[] currentArray)
        {
            this.array = currentArray;
        }
        public bool hasNext()
        {
            return position < array.Length;
        }
        public T next()
        {
            int i = position;
            position = i + 1;
            return array[i];
        }
    }
}
