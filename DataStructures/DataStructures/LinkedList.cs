using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class LinkedList<T>
    {
        private Node<T> Head;
        private int Size;

        public void AddFront(T value)
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

        public void AddBack(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value is invalid for inclusion");
            }
            Node<T> newNode = new Node<T>(value);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node<T> last = GetLastNode();
            last.Next = newNode;
            Size++;
        }

        public T GetFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the list is empty");
            }
            return Head.Data;
        }

        public T GetLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the list is empty");
            }
            Node<T> last = GetLastNode();
            return last.Data;
        }

        public bool Contains(T value)
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the list is empty");
            }
            else if (value == null)
            {
                throw new ArgumentNullException("Value is invalid for deletion");
            }

            if (Head.Data.Equals(value))
            {
                return true;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    if (current.Next.Data.Equals(value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsEmpty()
        {
            return (Head == null || Size == 0);
        }

        public int Count()
        {
            return Size;
        }

        public void Clear()
        {
            Head = null;
            Size = 0;
            GC.Collect();
        }

        public void DeleteByValue(T value)
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the list is empty");
            }
            else if(value == null)
            {
                throw new ArgumentNullException("Value is invalid for deletion");
            }

            if (Head.Data.Equals(value))
            {
                Head = Head.Next;
                Size--;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null)
                {
                    if (current.Next.Data.Equals(value))
                    {
                        current.Next = current.Next.Next;
                        Size--;
                        return;
                    }

                }
            }
            GC.Collect();
        }

        private Node<T> GetLastNode()
        {         

            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }


    }
}
