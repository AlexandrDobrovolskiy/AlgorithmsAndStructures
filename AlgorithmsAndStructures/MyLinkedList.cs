using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmsAndStructures
{
    public class MyLinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection where T : IComparable
    {
        private int _count;
        private Node head;

        public Node First => head;

        public Node Last => head.Prev;

        public MyLinkedList()
        {
        }

        public MyLinkedList(T[] array)
        {
            foreach (T item in array)
            {
                Add(item);
            }
        }

        public MyLinkedList(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Add(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            Node newNode = new Node(item);
            if(head == null)
                InternalInsertNodeToEmptyList(newNode);
            else
            {
                InternalInsertNodeBefore(head, newNode);
            }
        }

        public void AddAfter(T item, int index)
        {
            throw new NotImplementedException();
        }

        public void AddBefore(T item, int index)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(T item)
        {
            throw new NotImplementedException();
        }
        
        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
        
        private void InternalInsertNodeBefore(Node node, Node newNode)
        {
            newNode.Next = node;
            newNode.Prev = node.Prev;
            node.Prev.Next = newNode;
            node.Prev = newNode;
            ++this._count;
        }

        private void InternalInsertNodeToEmptyList(Node newNode)
        {
            newNode.Next = newNode;
            newNode.Prev = newNode;
            this.head = newNode;
            ++this._count;
        }

        int ICollection.Count
        {
            get { return _count; }
        }

        public bool IsSynchronized { get; }
        public object SyncRoot { get; }

        int ICollection<T>.Count
        {
            get { return _count; }
        }

        public bool IsReadOnly { get; }

        public class Node
        {
            private Node _next;
            public Node Next
            {
                get => _next;
                set => _next = value;
            }

            private Node _prev;
            public Node Prev
            {
                get => _prev;
                set => _prev = value;
            }

            private T _value;
            public T Value
            {
                get => _value;
                set => _value = value;
            }

            public Node(T value)
            {
                _value = value;
            }
        }
    }
}