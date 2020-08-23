using System;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }

    class Node
    {
        public BinaryTree Parent { get; set; }
        public BinaryTree Right { get; set; }
        public BinaryTree Left { get; set; }
        public int Data { get; set; }
        public Node(int data)
        {
            Data = data;
        }
    }

    class BinaryTree
    {
        public Node Head { get; set; }
        public int Depth { get; set; }
        public void Add(int value)
        {
            Node current = Head;
            if(current == null)
            {
                Head.Data = value;
            }
            while(current != null)
            {

            }
        }
    }
}
