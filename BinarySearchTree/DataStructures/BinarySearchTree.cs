namespace BinarySearchTree.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
using System.Xml.Linq;
    using BinarySearchTree.Interfaces;

    /*
     *  x.CompareTo(y):
     *  > 0 = x is bigger than y
     *  0 = same position
     *  < 0 = x is smaller than y 
     */

    public class BinarySearchTree<T> : IBST_G<T> where T : IComparable<T>
    {
        private Node<T>? Root = null;

        public int Count()
        {



            throw new NotImplementedException();
        }
        public bool Exists(T value)
        {
            // If root.data is != value, check next left node value, if left node value > value, go right


            throw new NotImplementedException();
        }
        public void Insert(T value)
        {
            // Find empty node to get inserted into
            // If found a non empty node, if value > data, go right. if value < data, go left.

            Node<T>? insertNode = new(value);
            if (Root == null) Root = insertNode;

            Root = InsertRecursively(Root, insertNode);


        }

        public Node<T> InsertRecursively(Node<T>? parentNode, Node<T> insertNode)
        {
           
            if (parentNode == null) parentNode = insertNode;

            if (parentNode.Data.CompareTo(insertNode.Data) > 0)
                    parentNode.LeftChild = InsertRecursively(parentNode.LeftChild, insertNode);

            else if (parentNode.Data.CompareTo(insertNode.Data) < 0)
                    parentNode.RightChild = InsertRecursively(parentNode.RightChild, insertNode);
            

            return parentNode;
        }

        public void Print()
        {
            Queue<Node<T>?> nodes = new Queue<Node<T>?>();
            Queue<Node<T>?> newNodes = new Queue<Node<T>?>();
            nodes.Enqueue(Root);
            int depth = 0;

            bool exitCondition = false;
            while (nodes.Count > 0 && !exitCondition)
            {
                depth++;
                newNodes = new Queue<Node<T>?>();

                string xs = "[";
                foreach (var maybeNode in nodes)
                {
                    string data = maybeNode == null ? " " : "" + maybeNode.Data;
                    if (maybeNode == null)
                    {
                        xs += "_, ";
                        newNodes.Enqueue(null);
                        newNodes.Enqueue(null);
                    }
                    else
                    {
                        Node<T> node = maybeNode;
                        string s = node.Data.ToString();
                        xs += s.Substring(0, Math.Min(4, s.Length)) + ", ";
                        if (node.LeftChild != null) newNodes.Enqueue(node.LeftChild);
                        else newNodes.Enqueue(null);
                        if (node.RightChild != null) newNodes.Enqueue(node.RightChild);
                        else newNodes.Enqueue(null);
                    }
                }
                xs = xs.Substring(0, xs.Length - 2) + "]";

                Console.WriteLine(xs);

                nodes = newNodes;
                exitCondition = true;
                foreach (var m in nodes)
                {
                    if (m != null) exitCondition = false;
                }
            }
        }
    }
}
