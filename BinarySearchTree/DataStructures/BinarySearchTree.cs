namespace BinarySearchTree.DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BinarySearchTree.Interfaces;

    public class BinarySearchTree<T> : IBST_G<T> where T : IComparable<T>
    {

        private readonly Node<T>? Root = null;

        public int Count()
        {



            throw new NotImplementedException();
        }
        public bool Exists(T value)
        {



            throw new NotImplementedException();
        }
        public void Insert(T value)
        {



            throw new NotImplementedException();
        }

    }
}
