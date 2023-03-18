using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_list_CSharp
{
    internal class ArrayList<T>:List<T>
    {
        public const int INITIAL_SIZE = 2;
        private T[] array;
        private int size;
    public ArrayList()
        {
            array = (new T[INITIAL_SIZE]);
        }
        public void addAtTail(T data)
        {
            if (size == array.Length)
            {
                increaseSize();
            }
            array[size] = data;
            size++;
        }
        public void addAtHead(T data)
        {
            if (size == array.Length)
            {
                increaseSize();
            }
            for (int i = size; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = data;
            size++;
        }
        public void increaseSize()
        {
            T[] newArray = (new T[array.Length * 2]);

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
        public void remove(int index)
        {
            for (int i = index; i < size; i++)
            {
                array[i - 1] = array[i];
            }
            array[size - 1] = default(T);
            size--;
        }
        public void removeAll()
        {
            for (int i = 0; i < size; i++)
            {
                array[i] = default(T);
            }
            size = 0;
        }
        public void setAt(int index, T data)
        {
            if (index > size)
            {
                return;
            }
            array[index - 1] = data;
        }
        public T getAt(int index)
        {
            return (T)array[index - 1];
        }
        public void removeAllWithValue(T data)
        {
            int tam = size;
            for (int i = 0; i < tam; i++)
            {
                if (array[i] == null)
                {
                    return;
                }
                if (array[i].Equals(data))
                {
                    remove(i + 1);
                    i--;
                }
            }
        }
        public int getSize()
        {
            return size;
        }
        public Iterator<T> getIterator()
        {
            return new ArrayListIterator<T>(array);
        }
    }
}
