using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    /// <summary>
    /// Dynamic Collection of elements in an stack format with utilitie methods to manipulate it. 
    /// </summary>
    /// <typeparam name="T">Type of the srack</typeparam>
    public class Stack<T>
    {
        /// <summary>
        /// Nodes yith the data
        /// </summary>
        private Node<T> Head { get; set; }

        /// <summary>
        /// Stack elements count
        /// </summary>
        private int Size { get; set; }

        /// <summary>
        /// Stack elements count
        /// </summary>
        /// <returns>Int with the number of elements int the stack</returns>
        public int Count()
        {
            return Size;
        }

        /// <summary>
        /// Check if the stack is empty
        /// </summary>
        /// <returns>TRUE if it is empty FALSE otherwise</returns>
        public bool IsEmpty()
        {
            return (Head == null || Size == 0);
        }

        /// <summary>
        /// Recover the first object in the stack
        /// </summary>
        /// <returns>First object in teh stack</returns>
        /// <exception cref="InvalidOperationException">If the stack is empty</exception>
        public T Peek ()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can't realize this operation because the stack is empty");
            }

            return Head.Data;
        }

        /// <summary>
        /// Inser element in the first position of the stack
        /// </summary>
        /// <param name="value">Value to be incerted</param>
        /// <exception cref="ArgumentNullException">Value can not be null</exception>
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

        /// <summary>
        /// Recover the frist element of the stack and removes it
        /// </summary>
        /// <returns>First element os the stack</returns>
        /// <exception cref="InvalidOperationException">If the stack is empty</exception>
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
