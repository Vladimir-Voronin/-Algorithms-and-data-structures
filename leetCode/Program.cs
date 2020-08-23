using System;

namespace leetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9}, 3);
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
                nums.CopyTo(arr,0);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i + nums.Length - k < nums.Length) nums[i] = arr[i + nums.Length - k];
                    else nums[i] = arr[i - k];
                }
            }
            //while (k >= nums.Length) k -= nums.Length;
            //if (nums.Length > 1 && k != 0)
            //{
            //    int[] arr = new int[nums.Length];
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if(i + k < nums.Length) arr[i] = nums[i + k];
            //        else arr[i] = nums[i + k - nums.Length];
            //    }
            //    nums = arr;
            //}







            //while (k >= nums.Length) k -= nums.Length;
            //if (nums.Length > 1 && k != 0)
            //{
            //    int saveprev = nums[nums.Length - k];
            //    int savenext = nums[0];
            //    int iter = nums.Length - k;
            //    int saveiter = nums.Length + 1;
            //    int shift = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        if (iter == saveiter)
            //        {
            //            shift++;
            //        }
            //        if(iter + k >= nums.Length)
            //        {
            //            if (iter == saveiter) saveprev = nums[nums.Length - k + shift];
            //            saveiter = iter;
            //            saveprev = nums[iter + shift];
            //            iter = iter - nums.Length + shift;
            //        }
            //        else
            //        {
            //        }
            //        iter += k;
            //        savenext = nums[iter];
            //        nums[iter] = saveprev;
            //        saveprev = savenext;
            //    }
            //}




            //if(nums.Length > 1)
            //{
            //    while (k > nums.Length) k -= nums.Length;
            //    int save1 = 0;
            //    int save2 = nums[0];
            //    int step = 0;
            //    if (nums.Length % k == 0) // Есть ли общий делитель?
            //    {
            //        for (int i = 0; i < k; i++)
            //        {
            //            step = 0;
            //            while (i + step < nums.Length)
            //            {
            //                if (step == 0)
            //                {
            //                    save1 = nums[i];
            //                    nums[i] = nums[nums.Length - k + i];
            //                    step += k;
            //                }
            //                else
            //                {
            //                    save2 = nums[i + step];
            //                    nums[i + step] = save1;
            //                    save1 = save2;
            //                    step += k;
            //                }
            //            }
            //        }
            //    }
            //    else
            //    {
            //        int iter = nums.Length - k;
            //        save1 = nums[iter];
            //        for (int i = 0; i < nums.Length; i++)
            //        {
            //            if (iter + k >= nums.Length) iter = iter - nums.Length + k;
            //            else iter += k;
            //            save2 = nums[iter];
            //            nums[iter] = save1;
            //            save1 = save2;
            //        }
            //    } 
            //}

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
