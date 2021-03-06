namespace BinarySearchTree.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBST_VG<T> where T : IComparable<T>
    {
        // Remove a value from the tree
        public void Remove(T value);

        // You need a method to balance the tree, whenever it is unbalanced. All methods that change the tree can cause it to become unbalanced.
        public void Balance();

        // Methods that you may find useful:
        // private int GetMaxDepth()
        // private int GetMinDepth()

    }
}
