using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    /// <summary>
    /// Dynamic Collection of elements in an list format with utilitie methods to manipulate it. 
    /// </summary>
    /// <typeparam name="T">Type of the list</typeparam>
    public class LinkedList<T>
    {
        /// <summary>
        /// Nodes yith the data
        /// </summary>
        private Node<T> Head;

        /// <summary>
        /// List elements count
        /// </summary>
        private int Size;

        /// <summary>
        /// Add a iten to the beginning of the list
        /// </summary>
        /// <param name="value">Value to be add</param>
        /// <exception cref="ArgumentNullException">If value is null</exception>
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

        /// <summary>
        /// Add a iten to the end of the list
        /// </summary>
        /// <param name="value">Value to be add</param>
        /// <exception cref="ArgumentNullException">If value is null</exception>
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

        /// <summary>
        /// Gets the first element 
        /// </summary>
        /// <returns>First iten</returns>
        /// <exception cref="InvalidOperationException">If list is empty</exception>
        public T GetFirst()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the list is empty");
            }
            return Head.Data;
        }

        /// <summary>
        /// Gets the last element 
        /// </summary>
        /// <returns>Last iten</returns>
        /// <exception cref="InvalidOperationException">If list is empty</exception>
        public T GetLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the list is empty");
            }
            Node<T> last = GetLastNode();
            return last.Data;
        }

        /// <summary>
        /// Check if the value is contain in the list
        /// </summary>
        /// <param name="value">Value to be checked</param>
        /// <returns>TRUE if it contains the value FALSE otherwise</returns>
        /// <exception cref="InvalidOperationException">If list is empty</exception>
        /// <exception cref="ArgumentNullException">If value is null</exception>
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

        /// <summary>
        /// Check if the list is empty
        /// </summary>
        /// <returns>TRUE if it is empty FALSE otherwise</returns>

        public bool IsEmpty()
        {
            return (Head == null || Size == 0);
        }

        /// <summary>
        /// List elements count
        /// </summary>
        /// <returns>Int with the number of elements int the list</returns>
        public int Count()
        {
            return Size;
        }

        /// <summary>
        /// Remove all the itens from the list
        /// </summary>
        public void Clear()
        {
            Head = null;
            Size = 0;
            GC.Collect();
        }

        /// <summary>
        /// Remove iten by value
        /// </summary>
        /// <param name="value">Iten to be remove</param>
        /// <exception cref="InvalidOperationException">If list is empty</exception>
        /// <exception cref="ArgumentNullException">If value is null</exception>
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

        /// <summary>
        /// Get the last node of the list
        /// </summary>
        /// <returns>the last node of the list</returns>
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
