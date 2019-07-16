using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeProject
{
    public class BinarySearchTree
    {
        //member variables
        public Node root;



        //constructor
        public BinarySearchTree()
        {
            root = null;
        }



        //member methods

        public void Add(int value)
        {
            Node newNode = new Node(value);
            bool haveAddedItem = false;

            if (root == null)
            {
                root = newNode;
            }

            else
            {
                //If the root is present then we need to find where to insert it;
                //Make the variable 'current' = 'root'.
                //Have a while(boolean) loop that will look through and decide where to put the value;
                //IF (value < currentParentNode.value) => current = current.left;
                //IF the currentParentNode.left == null, then parent.left = newNode; This makes that null on the left become the child of the higher valued parent; AND BREAK;
                //ELSE repeat process for the right said since value will be greater than current.value
                Node currentParentNode = root;
                while (!haveAddedItem)
                {
                    if (value <= currentParentNode.data)
                    {
                        if (currentParentNode.left == null)
                        {
                            currentParentNode.left = newNode;
                            haveAddedItem = true;
                        }

                        else
                        {
                            currentParentNode = currentParentNode.left;
                        }
                    }

                    else
                    {
                        if (currentParentNode.right == null)
                        {
                            currentParentNode.right = newNode;
                            haveAddedItem = true;
                        }

                        else
                        {
                            currentParentNode = currentParentNode.right;
                        }
                    }
                }
            }
        }

        public bool Search(int value)
        {
            //First check to see if value equals the root, IF it does, return true;
            //ELSE, have a WHILE loop that is !haveFoundItem and recursively goes through the tree, looking for the value;
            //Be sure to add a way for the loop to end when the value is found or if left or right == null;
            bool haveFoundItem = false;
            if (value == root.data)
            {
                Console.WriteLine($"{value} is the root of the tree!");
                return true;
            }

            else
            {
                Node currentParentNode = root;
                while (!haveFoundItem)
                {
                    if (value <= currentParentNode.data)
                    {
                        if (currentParentNode.left == null)
                        {
                            Console.WriteLine($"{value} not found in tree!");
                            return false;
                        }

                        else if (value == currentParentNode.left.data)
                        {
                            Console.WriteLine($"{value} was found in the tree!");
                            haveFoundItem = true;
                            return true;
                        }

                        else
                        {
                            currentParentNode = currentParentNode.left;
                        }
                    }

                    else
                    {
                        if (currentParentNode.right == null)
                        {
                            Console.WriteLine($"{value} not found in tree!");
                            return false;
                        }

                        else if (value == currentParentNode.right.data)
                        {
                            Console.WriteLine($"{value} was found in the tree!");
                            haveFoundItem = true;
                            return true;
                        }

                        else
                        {
                            currentParentNode = currentParentNode.right;
                        }
                    }
                }
            }
            return false;
        }
    }
}
