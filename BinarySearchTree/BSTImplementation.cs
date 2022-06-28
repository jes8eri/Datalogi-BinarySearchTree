namespace BinarySearchTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using DataStructures;

    public static class BSTImplementation
    {

        public static void Run()
        {
            var BST = new BinarySearchTree<int>();

            BST.Insert(100);
            BST.Insert(50);
            BST.Insert(75);
            BST.Insert(14);
            BST.Insert(7);
            BST.Insert(8);
            BST.Insert(17);
            BST.Insert(101);

            BST.Print();
            Console.WriteLine(BST.Count());
        }

    }
}
