using System;
using DataStructures.LinkedList.DoublyLinkedList;

namespace DataStructures.Queue
{
    public class LinkedListQueue<T> : IQueue<T>
    {
        private readonly DoublyLinkedList<T> list = new DoublyLinkedList<T>();
        public int Count { get; private set; }
        public void EnQueue(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
            list.AddLast(value);
            Count++;
        }
        public T DeQueue()
        {
            if (Count == 0)
                throw new Exception("Empty queue!");
            var temp = list.RemoveFirst();
            Count--;
            return temp;
        }
        public T Peek() => Count == 0
            ? throw new Exception("Empty Queue!")
            : list.Head.Value;
    }
}