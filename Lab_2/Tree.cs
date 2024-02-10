using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Tree<T> : IEnumerable
        where T : IComparable<T>
    {
        Node<T> root;

        public Tree(T val) 
        {
            root = new(val);
        }

        public void Add(T val) 
        {
            root.Add(val);
        }

        public void Print()
        {
            root.Print();
        }

        public int LeavesAmount()
        {
            int count = 0;
            return root.LeavesCounter(count);
        }

        public IEnumerator GetEnumerator()
        {
            List<T> leaves = new();
            root.GetLeaves(leaves);
            foreach (T leaf in leaves)
                yield return leaf;
        }
    }
}
