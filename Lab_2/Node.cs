using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Node<T> where T : IComparable<T>
    {
        public T value;
        public Node<T>? left = null;
        public Node<T>? right = null;

        public Node(T val) // конструктор
        {
            value = val;
        }

        public void Print()
        {
            // LNR вывод
            left?.Print();
            Console.WriteLine(value + " ");
            right?.Print();
        }

        public void Add(T val)
        {
            if (val.CompareTo(value) < 0)
            {
                if (left == null) left = new(val);
                else left.Add(val);
            }
            else
            {
                if (right == null) right = new(val);
                else right.Add(val);
            }
        }

        public int LeavesCounter(int count)
        {
            if (left != null)
                count = left.LeavesCounter(count);
            if (right != null)
                count = right.LeavesCounter(count);
            if (left == null && right == null)
                count++;
            return count;
        }

        public void GetLeaves(List<T> leaves)
        {
            left?.GetLeaves(leaves);
            right?.GetLeaves(leaves);
            if (left == null && right == null)
                leaves.Add(value);
        }
    }
}
