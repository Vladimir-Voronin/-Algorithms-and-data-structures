using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>{ 0, 6, 1, 2, 5, 3, 5, 3 };

            AlgoritmList arr = new AlgoritmList(array, true);

            AlgoritmList.ConsWrite(arr.MyArray);
            AlgoritmList.ConsWrite(arr.SortArray);
            Console.WriteLine(arr.Min(2));
            AlgoritmList.ConsWrite(arr.UniqueArray);

            List<int> array2 = new List<int> { -5, 11, 2 };
            List<int> combined = arr.AddToArray(array2);
            AlgoritmList.ConsWrite(combined);
        }
    }

    class AlgoritmList
    {
        public List<int> MyArray { get; set; }

        public List<int> SortArray { get; private set; } = null;

        public List<int> UniqueArray { get; private set; } = null;

        //<summary>   
        //If dynamic is true, all basics algoritms will be held
        //</summary>
        public AlgoritmList(List<int> array, bool dynamic = false)
        {
            MyArray = array;

            if (dynamic)
            {
                SortArray = BaseInsertionSort(MyArray);
                UniqueArray = UniqueList();
            }
        }

        //<summary>   
        //Typical Bubble sort. Time function = O(N^2)
        //</summary>
        private List<int> BaseBubbleSort(List<int> array)
        {
            List<int> NewArray = new List<int>(array);
            for (int i = 0; i < NewArray.Count; i++)
            {
                for (int k = 0; k < NewArray.Count - 1 - i; k++)
                {
                    if (MyArray[k + 1] < NewArray[k])
                    {
                        int a = NewArray[k + 1];
                        NewArray[k + 1] = NewArray[k];
                        NewArray[k] = a;
                    }
                }
            }
            return NewArray;
        }

        //<summary>   
        //InsertionSort. Time function = O(N^2) (maximum, real: O(N) > t >= O(N^2))
        //</summary>
        private List<int> BaseInsertionSort(List<int> array)
        {
            List<int> NewArray = new List<int>(array);
            for (int i = 1; i < NewArray.Count; i++)
            {
                int taken = NewArray[i];
                int k = i;
                while (k > 0 && taken < NewArray[k - 1])
                {
                    NewArray[k] = NewArray[k - 1];
                    k--;
                }
                NewArray[k] = taken;
            }
            return NewArray;
        }

        //<summary>   
        //Combined two arrays and return sorted array
        //</summary>
        public List<int> AddToArray(List<int> secarr)
        {
            if(SortArray == null)
            {
                throw new Exception("You need to initialize object with dynamic = true, to define SortArray");
            }

            List<int> array = BaseInsertionSort(secarr);
            int a = 0;
            int b = 0;
            List<int> result = new List<int>();
            while(a < SortArray.Count && b < array.Count)
            {
                if (SortArray[a] < array[b])
                {
                    result.Add(SortArray[a]);
                    a++;
                }
                else
                {
                    result.Add(array[b]);
                    b++;
                }
                if (a >= SortArray.Count)
                {
                    result.AddRange(array.GetRange(b, array.Count - b));
                    break;
                }
                if (b >= array.Count)
                {
                    result.AddRange(array.GetRange(a, SortArray.Count - a));
                    break;
                }
            }
            return result;
        }


        //<summary>   
        //many - How min element will return
        //</summary//
        public int Min(int many)
        {
            if (many < 1)
            {
                throw new Exception("Many cant be < 1");
            }

            if (many > SortArray.Count)
            {
                throw new Exception("Many cant be > then Lenght of list");
            }
            return SortArray[many - 1];
        }


        public List<int> UniqueList()
        {
            List<int> unique = new List<int>();
            foreach (int a in SortArray)
            {
                if (unique.Contains(a)) { }
                else { unique.Add(a); }
            }
            return unique;
        }

        public static void ConsWrite(List<int> array)
        {
            Console.WriteLine("{0}", string.Join(", ", array));
        }     
    }
}
