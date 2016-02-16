using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    class Node
    {
        // declare public int data type variable item
        public int item;
        // declare public Node data type named leftc;it's not a variable???
        public Node leftc;
        // declare public Node data type named rightc
        public Node rightc;
        // creat a method named display
        public void display()
        {// Console.Write() don't change the line after print the text
            Console.Write("[");
            Console.Write(item);
            Console.Write("]");
        }

    }
    class Tree
    {
        // declare public Node named root
        public Node root;
        // creat a default constructor 
        public Tree()
        {// node root refer to null
            root = null;
        }

        // creat a method named ReturnRoot and output is Node data type
        public Node ReturnRoot()
        {
            // return root
            return root;
        }

        // creat a public method named Insert and 
        //it has no output and has int input
        public void Insert(int id)
        {
            // creat a Node object named newNode
            Node newNode = new Node();
            // assign id to newNode.item
            newNode.item = id;
            // if root == null is true, root refer to the heap that newNode refer to
            if (root == null)
                root = newNode;
            // if root == null is false
            // current refer to the heap that root refer to and declare a node named parent
            else
            {
                Node current = root;
                Node parent;
                // while loop 
                while(true)
                {
                    // root == null is false. parent refer to the heap that current refer to 
                    parent = current;
                    // if id < current.item
                    if (id < current.item)
                    {
                        // current refer to the heap of current.leftc
                        current = current.leftc;
                        // if current == null is true
                        // parent.leftc refer to the heap of newNode and return so while loop stops
                        if (current == null)
                        {
                            parent.leftc = newNode;
                            return;
                        }
                    }
                    // if id > = current.item
                    else
                    {
                        // current refer to the heap of current.rightc
                        current = current.rightc;
                        // if current == null is true, parent.rightc refer to the heap of newNode
                        // return so the while loop stops
                        // if current == null is fasle
                        //go back to the beginning of the loop with current refer to the heap of current.rightc
                        if (current == null)
                        {
                            parent.rightc = newNode;
                            return;
                        }
                    }

                }
            }
        }

        // creat a method named Preorder and Node Root is the input 

        public void Preorder(Node Root)
        {
            // if Root != null is true
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.leftc);
                Preorder(Root.rightc);
            }
        }

        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.leftc);
                Console.Write(Root.item + " ");
                Inorder(Root.rightc);

            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.leftc);
                Postorder(Root.rightc);
                Console.Write(Root.item + " ");

            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Tree theTree = new Tree();
            theTree.Insert(20);
            theTree.Insert(25);
            theTree.Insert(45);
            theTree.Insert(15);
            theTree.Insert(67);
            theTree.Insert(43);
            theTree.Insert(80);
            theTree.Insert(33);
            theTree.Insert(67);
            theTree.Insert(91);
            Console.WriteLine("Inorder Traversal : ");
            theTree.Inorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Preorder Traversal : ");
            theTree.Preorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
            Console.WriteLine("Postorder Traversal : ");
            theTree.Postorder(theTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
}
