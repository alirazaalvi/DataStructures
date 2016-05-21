namespace LinkedList
{
    public class LinkedList<T> : ILinkedList<T>
    {
        public LinkedListNode<T> Head { get; set; }
        private int Count { get; set; }

        public void AddFirst(T value)
        {
            //creating LinkedListNode object from passed value
            var newItem = new LinkedListNode<T>(value);

            //copying the head value to a temp variable
            var formalHead = Head;

            //assigning new value to head
            Head = newItem;

            //assigning head as the next value to newly added value
            Head.Next = formalHead;

            //incrementing the count
            Count++;
        }

        public void Add(T value)
        {
            //creating a new linkedlist node object from passed value
            var newItem = new LinkedListNode<T>(value);

            if (Head == null)
            {
                Head = newItem;
            }
            else
            {
                var currentItem = Head;
                while (currentItem.Next != null)
                {
                    currentItem = currentItem.Next;
                }

                currentItem.Next = newItem;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            Head = Head.Next;
            Count--;
        }

        public void Remove(int index)
        {
            //if index is bigger than linked list size or less than 0 than no processing will be done.
            if (index > Count || index < 0)
            {
                return;
            }


            var itemToRemove = Head;

            //in case of first index calling remove first element method
            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            //getting the element before the element to remove
            for (var i = 0; i < index - 1; i++)
            {
                itemToRemove = itemToRemove.Next;
            }

            //replacing the element to remove with the next element
            itemToRemove.Next = itemToRemove.Next.Next;
            Count--;
        }

        public int Size()
        {
            return Count;
        }
    }
}