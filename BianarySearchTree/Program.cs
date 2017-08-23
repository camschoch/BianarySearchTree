using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BianarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree b = new BinarySearchTree();

            b.insert('A');
            b.insert('H');
            b.insert('Y');
            b.insert(16);
            b.insert('W');
            b.insert('C');

            b.display();

            bool test = b.search(6);
            Console.Write("\n" + test);

            Console.ReadLine();
        }
    }
}
