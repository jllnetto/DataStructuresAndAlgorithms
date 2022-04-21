using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class TreeNode<T>
    {
        public int Key { get; set; }

        public T Value { get; set; }

        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(int key, T value)
        {
            Key = key;
            Value = value;
        }

        public TreeNode min()
        {
            if(Left==null)
            {
                return this;
            }
            else
            {
                return Left.min();
            }
        }

    }
}
