using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_list_CSharp
{
    internal interface List <T>
    {
        void addAtTail(T data);
        void addAtHead(T data);
        void increaseSize();
        void remove(int index);
        void removeAll();
        void setAt(int index, T data);
        T getAt(int index);
        void removeAllWithValue(T data);
        int getSize();
        Iterator<T> getIterator();
    }
}
