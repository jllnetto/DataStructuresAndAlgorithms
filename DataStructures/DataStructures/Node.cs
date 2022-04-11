using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    /// <summary>
    /// Basic node for LinkedList, Queue and Stack
    /// </summary>
    /// <typeparam name="T">Type of teh node</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Data
        /// </summary>
        public T Data;

        /// <summary>
        /// Next Node
        /// </summary>
        public Node<T> Next;

        /// <summary>
        /// Cantructor to set the basic value of the Node
        /// </summary>
        /// <param name="value">Value to be set in this Node</param>
        public Node(T value)
        {
            Data = value;
        }
    }
}
