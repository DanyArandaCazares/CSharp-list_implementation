using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_list_CSharp
{
    internal interface Iterator<T>
    {
        bool hasNext();
        T next();
    }
}
