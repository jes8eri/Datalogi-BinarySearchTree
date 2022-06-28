namespace BinarySearchTree.DataStructures
{
    using System;
    using System.Collections.Generic;
    using BinarySearchTree.Interfaces;

    public class BinarySearchTree<T> : IBST_G<T> where T : IComparable<T>
    {
        private Node<T>? Root = null;

        /// <summary>
        /// Calls the recursive method for counting non null nodes.
        /// </summary>
        /// <returns> Amount of valid nodes. </returns>
        public int Count() => CountRecursively(Root);

        /// <summary>
        /// Counts the non null objects in the BinarySearchTree. Adds 1 whenever the node isn't null.
        /// </summary>
        /// <param name="node">The current node.</param>
        /// <returns> The amount of non null recursive calls that have been added up. </returns>
        private int CountRecursively(Node<T>? node) => node == null ? 0 : CountRecursively(node.LeftChild) + CountRecursively(node.RightChild) + 1;

        /// <summary>
        /// Calls the recursive method for finding a specific value.
        /// </summary>
        /// <param name="value">The value to be found.</param>
        /// <returns>True if the value is found, false if it is not.</returns>
        public bool Exists(T value) => ExistsRecursively(Root, value);

        /// <summary>
        /// Goes through all the nodes recursively looking for the specified value.
        /// <para/> Searches the left side and compares the data to the value, if found, return true. If not found, check the right side of the tree.
        /// </summary>
        /// <param name="node">The current node.</param>
        /// <param name="value">The value to be found.</param>
        /// <returns>True if the value exists in either the left or right side of the tree.</returns>
        private bool ExistsRecursively(Node<T>? node, T value)
        {
            if (node == null) return false;
            if (value.CompareTo(node.Data) == 0) return true;

            return ExistsRecursively(node.LeftChild, value) || ExistsRecursively(node.RightChild, value);
        }
        /// <summary>
        /// Calls the recursive method for inserting a value into the BinarySearchTree.
        /// </summary>
        /// <param name="value">The value to be inserted.</param>
        public void Insert(T value)
        {
            // Find empty node to get inserted into
            // If found a non empty node, if value > data, go right. if value < data, go left.

            Node<T>? insertNode = new(value);

            if (Root == null) Root = insertNode;
                Root = InsertRecursively(Root, insertNode);
        }

        /// <summary>
        /// Inserts the specified value into the BinarySearchTree.
        /// <para/> If the value of the parentNode is larger than the value to be inserted, continue recursively down the left path of the tree. If the inserted value is higher, continue right.
        /// </summary>
        /// <param name="parentNode">The parent/original node to compare against.</param>
        /// <param name="insertNode">The new node to be inserted.</param>
        /// <returns></returns>
        private Node<T> InsertRecursively(Node<T>? parentNode, Node<T> insertNode)
        {
            if (parentNode == null) parentNode = insertNode;

            if (parentNode.Data.CompareTo(insertNode.Data) > 0)
                parentNode.LeftChild = InsertRecursively(parentNode.LeftChild, insertNode);
            else if (parentNode.Data.CompareTo(insertNode.Data) < 0)
                parentNode.RightChild = InsertRecursively(parentNode.RightChild, insertNode);

            return parentNode;
        }

        /// <summary>
        /// Prints all the nodes in the BinarySearchTree
        /// <para/> Code from lejonmanen - https://gist.github.com/lejonmanen/0580091a3ff824fcce537fe5523e4ce8
        /// -Edited slightly to remove IntelliSense messages.
        /// </summary>
        public void Print()
        {
            Queue<Node<T>?> nodes = new();
            Queue<Node<T>?> newNodes = new();
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
                        string? s = node.Data.ToString();
                        xs += s?[..Math.Min(4, s.Length)] + ", ";
                        if (node.LeftChild != null) newNodes.Enqueue(node.LeftChild);
                        else newNodes.Enqueue(null);
                        if (node.RightChild != null) newNodes.Enqueue(node.RightChild);
                        else newNodes.Enqueue(null);
                    }
                }
                xs = xs[0..^2] + "]";

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
