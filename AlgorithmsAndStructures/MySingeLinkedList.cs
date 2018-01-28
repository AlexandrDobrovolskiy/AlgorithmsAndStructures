using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace AlgorithmsAndStructures
{
    public class MySingeLinkedList<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection where T : IComparable
    {
        private SLLNode first;
        private SLLNode last;
        private int count;
        public int Count => this.count;
        public bool IsSynchronized { get; }
        public object SyncRoot { get; }
        public bool IsReadOnly { get; }
        public SLLNode First => this.first;
        public SLLNode Last => this.last;
        
        
        public void Add(T item)
        {
            AddLast(item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            try
            {
                Search(item);
            }
            catch (ArgumentException e)
            {
                return false;
            }

            return true;
        }
        

        public void CopyTo(T[] array, int arrayIndex)
        {
            SLLNode currentNode = GetNode(arrayIndex);
            for (int i = arrayIndex; i < arrayIndex + count; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }
        }

        public bool Remove(T item)
        {
            SLLNode prev = GetNode(IndexOf(item) - 1);
            SLLNode next = prev.NextNode.NextNode;
            prev.NextNode = next;
            return true;
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public T this[int i]
        {
            get
            {
                if(i < 0 || i >= count)
                   throw new IndexOutOfRangeException($"There is no element with index {i}");
                return GetNode(i).Value;
            }
            set => GetNode(i).Value = value;
        }
        
        //from array
        public MySingeLinkedList(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof (collection));
            foreach (T obj in collection)
                this.AddLast(obj);
        }
        
        public MySingeLinkedList()
        {   
        }
        
        private SLLNode GetNode(int index)
        {
            if(index < 0 || index > count)
                throw new IndexOutOfRangeException($"The size of collection is {count}");
            
            SLLNode node = this.First;
            for (int j = 0; j < index; j++)
            {
                node = node.NextNode;
            }
        
            return node;
        }

        private SLLNode Search(T element)
        {
            SLLNode current = First;
            for (int i = 0; i < count; i++)
            {
                if (i == count - 1)
                    throw new ArgumentException($"There is no {element} node");
                
                if (current.Value.Equals(element))
                    break;
                current = current.NextNode;
            }

            return current;
        }

        public int IndexOf(T element)
        {
            SLLNode current = first;
            for (int i = 0; i < count; i++)
            {
                if (current.Value.Equals(element))
                    return i;
                current = current.NextNode;
            }

            return -1;
        }
        
        public void AddFirst(T element)
        {
            SLLNode newNode = new SLLNode(element) {NextNode = first};
            first = newNode;
            count++;
        }

        public void AddLast(T element)
        {
            if (count == 0)
            {
                first = new SLLNode(element);
                first.NextNode = last;
            }
            else
            {
                SLLNode newNode = new SLLNode(element);
                GetNode(count - 1).NextNode = newNode;
                newNode.NextNode = last;  
            }

            count++;
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class SLLNode
        {
            private T value;
            
            public T Value
            {
                get => value;
                set => this.value = value;
            }

            private  SLLNode nextNode;
            
            public SLLNode NextNode
            {
                get => nextNode;
                set => nextNode = value;
            }

            public SLLNode(T value)
            {
                this.value = value;
            }

            public SLLNode()
            {
            }
        }
    }
}