using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearch = new BinarySearchTree();
            binarySearch.Add(100);
            binarySearch.Add(50);
            binarySearch.Add(30);
            binarySearch.Add(75);
            binarySearch.Add(125);
            Console.WriteLine(binarySearch.root.left.left.data);
            Console.ReadLine();
            Console.WriteLine(binarySearch.root.data);
            Console.ReadLine();
        }
    }
}
