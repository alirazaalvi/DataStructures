using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface ILinkedList<T>
    {
        void Add(T value);
        void Remove(int index);
        void AddFirst(T value);
        void RemoveFirst();
        int Size();
    }
}
