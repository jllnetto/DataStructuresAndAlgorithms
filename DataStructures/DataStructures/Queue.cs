using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class Queue<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        private int Size { get; set; }

        public int Count()
        {
            return Size;
        }

        public bool IsEmpty()
        {
            return (Head == null || Size == 0);
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the queue is empty");
            }

            return Head.Data;
        }

        public void Add(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value is invalid for inclusion");
            }

            Node<T> newNode = new Node<T>(value);
            if(Tail == null)
            {
                Tail.Next = newNode;
            }

            Tail = newNode;

            if(Head==null)
            {
                Head = Tail;
            }
            Size++;
        }

        public T Remove()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the queue is empty");
            }

            T data = Head.Data;
            Head=Head.Next;
            if(Head==null)
            {
                Tail = null;
            }
            Size--;
            return data;
        }



    }
}
