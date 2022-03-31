using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node(T value)
        {
            Data = value;
        }
    }
}
