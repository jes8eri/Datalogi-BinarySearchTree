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

            BST.Insert(10);
            BST.Insert(20);
            BST.Insert(15);
            BST.Insert(2);
            BST.Insert(1);
            BST.Insert(3);
            BST.Insert(17);

            BST.Print();
        }

    }
}
