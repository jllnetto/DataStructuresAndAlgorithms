using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.DataStructures
{
    public class BinarySearchTree<T>
    {
        public TreeNode<T> Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public T Find(int key)
        {
            TreeNode<T> node = Find(Root, key);

            return node != null ? node.Value : default;
        }

        private TreeNode<T> Find(TreeNode<T> node, int key)
        {
            if (node == null || node.Key == key)
            {
                return node;
            }
            else if (key < node.Key)
            {
                return Find(node.Left, key);
            }
            else
            {
                return Find(node.Right, key);
            }
        }

        public void incert(int key, T value)
        {
            Root = InsertItem(Root, key, value);
        }

        private TreeNode<T> InsertItem(TreeNode<T> node, int key, T value)
        {
            TreeNode<T> newNode = new TreeNode<T>(key, value);

            if (node == null)
            {
                node = newNode;

                return node;
            }
            else if (key < node.Key)
            {
                node.Left = InsertItem(node.Left, key, value);
            }
            else if (key > node.Key)
            {
                node.Right = InsertItem(node.Right, key, value);
            }

            return node;
        }

        public void Delete(int key)
        {
            Root = Delete(Root, key);
        }

        private TreeNode<T> Delete(TreeNode<T> node, int key)
        {
            if (node == null)
            {
                return null;
            }
            else if (key < node.Key)
            {
                node.Left = Delete(node.Left, key);
            }
            else if (key > node.Key)
            {
                node.Right = Delete(node.Right, key);
            }
            else
            {
                if (node.Left == null && node.Right == null)
                {
                    node = null;
                }
                else if (node.Left == null)
                {
                    node = node.Right;
                }
                else if (node.Right == null)
                {
                    node = node.Left;
                }
                else
                {
                    TreeNode<T> minRight = FindMin(node.Right);
                    node.Key = minRight.Key;
                    node.Value = minRight.Value;
                    node.Right = Delete(node.Right, node.Key);
                }

            }

            return node;
        }

        public TreeNode<T> FindMin(TreeNode<T> node)
        {
            return node.min();
        }


        public void PrintInOrderTransversal()
        {
            InOrderTransversal(Root);
        }

        private void InOrderTransversal(TreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTransversal(node.Left);
                Console.WriteLine(node.Key);
                InOrderTransversal(node.Right);

            }
        }

        public void PrintPreOrderTransversal()
        {
            PreOrderTransversal(Root);
        }

        private void PreOrderTransversal(TreeNode<T> node)
        {
            if (node != null)
            {
                Console.WriteLine(node.Key);
                PreOrderTransversal(node.Left);
                PreOrderTransversal(node.Right);
            }

        }

        public void PrintPosOrderTransversal()
        {
            PosOrderTransversal(Root);
        }

        private void PosOrderTransversal(TreeNode<T> node)
        {
            if (node != null)
            {
                PosOrderTransversal(node.Left);
                PosOrderTransversal(node.Right);
                Console.WriteLine(node.Key);
            }

        }
    }
}
