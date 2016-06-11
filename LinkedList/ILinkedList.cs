namespace LinkedList
{
    internal interface ILinkedList<T>
    {
        void Add(T value);
        void Remove(int index);
        void AddFirst(T value);
        void RemoveFirst();
        int Size();
    }
}