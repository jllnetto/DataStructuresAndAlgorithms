using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    /// <summary>
    /// Dynamic Collection of elements in an queue format with utilitie methods to manipulate it. 
    /// </summary>
    /// <typeparam name="T">Type of the queue</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// Fist iten of the queue
        /// </summary>
        private Node<T> Head { get; set; }

        /// <summary>
        /// Last iten of the queue
        /// </summary>
        private Node<T> Tail { get; set; }

        /// <summary>
        /// Size of the queue
        /// </summary>
        private int Size { get; set; }

        /// <summary>
        /// Queue elements count
        /// </summary>
        /// <returns>Int with the number of elements int the queue</returns>
        public int Count()
        {
            return Size;
        }

        // <summary>
        /// Check if the queue is empty
        /// </summary>
        /// <returns>TRUE if it is empty FALSE otherwise</returns>
        public bool IsEmpty()
        {
            return (Head == null || Size == 0);
        }

        /// <summary>
        /// Recover the first object in the queue
        /// </summary>
        /// <returns>First object in teh queue</returns>
        /// <exception cref="InvalidOperationException">If the queue is empty</exception>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the queue is empty");
            }

            return Head.Data;
        }

        /// <summary>
        /// Inser element in the last position of the queue
        /// </summary>
        /// <param name="value">Value to be incerted</param>
        /// <exception cref="ArgumentNullException">Value can not be null</exception>
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

        /// <summary>
        /// Recover the last element of the queue and removes it
        /// </summary>
        /// <returns>Last element os the queue</returns>
        /// <exception cref="InvalidOperationException">If the queue is empty</exception>
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
