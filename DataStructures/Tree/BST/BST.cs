using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.Tree.BinaryTree;

namespace DataStructures.Tree.BST
{
    public class BST<T> : IEnumerable<T>
        where T : IComparable
    {
        public Node<T> Root { get; set; }
        public BST()
        {
            
        }

        public BST(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new BSTEnumerator<T>(Root);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
            var newNode = new Node<T>(value);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                var current = Root;
                Node<T> parent;
                while (true)
                {
                    parent = current;
                    // Sol-alt ağaç
                    if (value.CompareTo(current.Value) < 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    // Sağ-alt ağaç
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public Node<T> FindMin(Node<T> root)
        {
            var current = root;
            while (current.Left != null)
                current = current.Left;
            return current;
        }
        public Node<T> FindMax(Node<T> root)
        {
            var current = root;
            while (current.Right != null)
                current = current.Right;
            return current;
        }
        public Node<T> Find(Node<T> root, T key)
        {
            var current = Root;
            while (key.CompareTo(current.Value) != 0)
            {
                current = key.CompareTo(current.Value) < 0 ? current.Left : current.Right;

                if (current == null)
                    //throw new Exception("Could not found!");
                    return default(Node<T>);
            }

            return current;
        }
        public Node<T> Remove(Node<T> root, T key)
        {
            if (root == null)
                return root;

            switch (key.CompareTo(root.Value))
            {
                // rekürsif olarak ilerle
                case < 0:
                    root.Left = Remove(root.Left, key);
                    break;
                case > 0:
                    root.Right = Remove(root.Right, key);
                    break;
                default:
                {
                    // eşitlik durumu vardır, yani artık elemanı silebiliriz.
                    // tek çocuk ya da çocuksuz
                    if (root.Left == null)
                    {
                        return root.Right;
                    }
                    else if(root.Right == null)
                    {
                        return root.Left;
                    }

                    // iki çocuk var ise
                    root.Value = FindMin(root.Right).Value;
                    root.Right = Remove(root.Right, root.Value);

                    break;
                }
            }

            return root;
        }
    }
}
