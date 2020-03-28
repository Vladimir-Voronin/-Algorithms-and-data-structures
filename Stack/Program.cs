using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack1 = new MyStack<int>(3);
            Console.WriteLine(stack1.stack.Length);
            Console.WriteLine(stack1.IsEmpty());
            stack1.PrintStack();
            stack1.Push(8);
            stack1.PrintStack();
            Console.WriteLine(stack1.Count);
            Console.WriteLine(stack1.Size);
            stack1.Push(6);

            stack1.PrintStack();
            stack1.Pop();
            Console.WriteLine(stack1.Count);

            Console.WriteLine(stack1.IsEmpty());
            stack1.PrintStack();
            
            Console.WriteLine(stack1.Count);

        }
    }

    /// <summary>
    /// Realize Stack with fixed lenght
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyStack<T>
    {
        public T[] stack;
        int size = 5;
        public int Count { get; set; } = 0;
        public T[] Stack { get { return stack; } set { stack = value; } }
        public int Size
        {
            get { return size; }
            set { if (size <= 0)
                {
                    throw new Exception("Size cant be < 0");
                }
                size = value;
            }
        }
        public MyStack()
        {
            Stack = new T[Size];
        }

        public MyStack(int size)
        {
            Size = size;
            Stack = new T[size];
        }

        public MyStack(T[] array) : this()
        {
            Size = array.Length;
            Count = array.Length - 1;
            Stack = array;
        }

        public T this[int index]
        { 
            get 
            {
                if(index > Size)
                {
                    throw new Exception("You index is more then size of stack");
                }
                return Stack[index]; 
            }
        }

        /// <summary>
        /// Checking stack, true if stack is Empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Count == 0;
        }

        /// <summary>
        /// Paste variable in the summit of stack
        /// </summary>
        /// <param name="var"></param>
        public void Push(T var)
        {
            if(Count>=Size)
            {
                throw new Exception("Stack is Full");
            }
            Stack[Count++] = var;
        }

        public void Pop()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }
            Stack[Count - 1] = default(T);
            Count--;
        }

        public void PrintStack()
        {
            Console.WriteLine("{0}", string.Join(", ", Stack));
        }
    }
}
