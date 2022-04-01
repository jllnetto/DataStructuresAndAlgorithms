using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class Stack<T>
    {
        private Node<T> Head { get; set; }
        private int Size { get; set; }

        public int Count()
        {
            return Size;
        }

        public bool IsEmpty()
        {
            return (Head == null || Size == 0);
        }

        public T Peek ()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the stack is empty");
            }

            return Head.Data;
        }

        public void Push (T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value is invalid for inclusion");
            } 

            Node<T> newNode = new Node<T>(value);
            newNode.Next = Head;
            Head = newNode;
            Size++;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the stack is empty");
            }

            T data = Head.Data;
            Head = Head.Next;
            Size--;
            return data;

            
        }


    }
}
