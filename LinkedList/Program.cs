using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // TEST WITH STRING
            string[] array = { "One", "Two", "Three" };
            Console.WriteLine(array.Length);
            LinkedList<string> list = new LinkedList<string>(array);

            Console.WriteLine(list.Head.Value);

            List<string> Testlist = list.GetOriginalList();

            list.PrintOriginalList();

            list.Add("Four");
            Console.WriteLine(list.Tail.Value);


            list.PrintOriginalList();

            list.RemoveLast(2);

            list.PrintOriginalList();


            // TEST WITH INT
            int[] array2 = { 1, 5 , 3 };
            Console.WriteLine(array.Length);
            LinkedList<int> list2 = new LinkedList<int>(array2);

            Console.WriteLine($"count: {list2.count}");
            Console.WriteLine(list2.Head.Value);

            List<int> Testlist2 = list2.GetOriginalList();

            list2.PrintOriginalList();

            list2.Add(22);
            Console.WriteLine(list2.Tail.Value);

            list2.PrintOriginalList();

            Console.WriteLine($"count: {list2.count}");
 
            list2.RemoveLast(2);

            list2.PrintOriginalList();

            Console.WriteLine($"count: {list2.count}");
        }
    }

    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }

    class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public int count;

        public LinkedList()
        {
        }

        public LinkedList(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    Head = new Node<T>(array[i]);
                    Tail = Head;
                    count++;
                }
                else
                {
                    Tail.Next = new Node<T>(array[i]);
                    Tail = Tail.Next;
                    count++;
                }
            }
        }

        public List<T> GetOriginalList()
        {
            if (Head == null)
            {
                return null;
            }
            Node<T> currentNode = Head;
            List<T> result = new List<T>();
            
            while (currentNode != null)
            {
                result.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }
           
            return result;
        }

        public void Add(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
            }

            Node<T> currentNode = Tail;
            currentNode.Next = new Node<T>(value);
            Tail = currentNode.Next;
            count++;
        }

        //<summary>>
        //many - how many last variables delete (default = 1)
        //<</summary>>
        public void RemoveLast(int many = 1)
        {
            if (Head == null)
            {
                throw new Exception("No variables in this list");
            }
            if(many > count)
            {
                throw new Exception("argument many cant be greater then list lenght");
            }
            Node<T> currentNode = Head;
            for (int i = 0; many > i; i++)
            {
                if (Head.Next == null)
                {
                    Head = null;
                    count--;
                }
                else
                {
                    while (currentNode.Next != Tail)
                    {
                        currentNode = currentNode.Next;
                    }
                    currentNode.Next = null;
                    Tail = currentNode;
                    currentNode = Head;
                    count--;
                }
            }
        }

        public void PrintOriginalList()
        {
            if (Head == null)
            {
                Console.WriteLine("null");
            }
            else
            {
                Console.WriteLine("{0}", string.Join(", ", this.GetOriginalList()));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}

//Разобраться в интерфейсах IEnumerator, IEnumerable + реализовать конструктор нормально
