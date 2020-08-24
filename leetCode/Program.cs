using System;

namespace leetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3);
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 6, 2, 3, 5, 6 }));
            Console.WriteLine(SingleNumber(new int[] { 4,1,2,1,2}));
        }

        //Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
        //Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        public static int RemoveDuplic(int[] arr)
        {
            if (arr.Length == 0) return 0;
            int result = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != arr[i - 1])
                {
                    arr[result] = arr[i];
                    result++;
                }
            }
            return result;
        }

        //Say you have an array prices for which the ith element is the price of a given stock on day i.
        //Design an algorithm to find the maximum profit.You may complete as many transactions as you like (i.e., buy one and sell one share of the stock multiple times).
        public static int MaxProfit(int[] prices)
        {
            int result = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (i + 1 >= prices.Length)
                {
                    break;
                }

                while (prices[i] >= prices[i + 1])
                {
                    i++;
                    if (i + 1 >= prices.Length)
                    {
                        return result;
                        i--;
                        break;
                    }

                }
                if (prices[i] < prices[i + 1]) result -= prices[i];

                while (prices[i] <= prices[i + 1])
                {
                    i++;
                    if (i + 1 >= prices.Length)
                    {
                        result += prices[i];
                        i--;
                        break;
                    }

                }
                if (prices[i] > prices[i + 1]) result += prices[i];

            }
            return result;
        }

        //Given an array, rotate the array to the right by k steps, where k is non-negative.
        public static void Rotate(int[] nums, int k)
        {


            while (k >= nums.Length) k -= nums.Length;
            if (nums.Length > 1 && k != 0)
            {
                int[] arr = new int[nums.Length];
                nums.CopyTo(arr, 0);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i + nums.Length - k < nums.Length) nums[i] = arr[i + nums.Length - k];
                    else nums[i] = arr[i - k];
                }
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        //Given an array of integers, find if the array contains any duplicates.
        //Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.
        public static bool ContainsDuplicate(int[] nums)
        {
            //////Too lower
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int k = i; k < nums.Length; k++)
            //    {
            //        if (nums[i] == nums[k + 1]) return true;
            //    }
            //}
            //return false;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) return true;
            }
            return false;
        }

        //Given a non-empty array of integers, every element appears twice except for one. Find that single one.
        //Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
        public static int SingleNumber(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            Array.Sort(nums);
            int save = nums[0];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1]) {
                    save = nums[i + 1];
                    continue;
                } 
                if (i == nums.Length - 2) return nums[i + 1];
                if (i == 0 && nums[i] != nums[i + 1]) return nums[i];
                if(save != nums[i+1] && nums[i+1] != nums[i+2]) return nums[i + 1];
            }
            return 0;
        }
    }
}
