using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianarySearchTree
{
    class Node
    {
        public int item;
        public Node rightLeaf;
        public Node leftLeaf;
        
        public Node(int value)
        {
            item = value;
            rightLeaf = null;
            leftLeaf = null;
        }

        public void insertData(ref Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);

            }
            else if (node.item < data)
            {
                insertData(ref node.rightLeaf, data);
            }

            else if (node.item > data)
            {
                insertData(ref node.leftLeaf, data);
            }
        }

        public bool search(Node node, int i)
        {
            if (node == null)
                return false;

            if (node.item == i)
            {
                return true;
            }
            else if (node.item < i)
            {
                return search(node.rightLeaf, i);
            }
            else if (node.item > i)
            {
                return search(node.leftLeaf, i);
            }

            return false;
        }

        public void display(Node n)
        {
            if (n == null)
            {
                return;
            }

            display(n.leftLeaf);
            Console.Write(" " + n.item);
            display(n.rightLeaf);
        }

    }
}
