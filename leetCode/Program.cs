using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(7 / 2);
            //Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3);
            //Console.WriteLine(ContainsDuplicate(new int[] { 1, 6, 2, 3, 5, 6 }));
            //Console.WriteLine(SingleNumber(new int[] { 3, 4, 1, 2, 1, 2 }));
            //Console.WriteLine(Intersect(new int[] { 2, 1, 3, 2 }, new int[] { 1, 4, 2, 2, 5 }));
            //PlusOne(new int[] { 9 });
            //MoveZeroes(new int[] { 1, 0, 0, 2, 5, 6 });
            //TwoSum(new int[] { -1, -2, -3, -4, -5 }, -8);

            //Console.WriteLine();
            //char[][] ver = new char[][]{
            //new char[]{'5','3','.','.','7','.','.','.','.'},
            //new char[]{'6','.','.','1','9','5','.','.','.'},
            //new char[]{'.','9','8','.','.','.','.','6','.'},
            //new char[]{'8','.','.','.','6','.','.','.','3'},
            //new char[]{'4','.','.','8','.','3','.','.','1'},
            //new char[]{'7','.','.','.','2','.','.','.','6'},
            //new char[]{'.','6','.','.','.','.','2','8','.'},
            //new char[]{'.','.','.','4','1','9','.','.','5'},
            //new char[]{'.','.','.','.','8','.','.','7','9'}
            //};
            //Console.WriteLine(ver[1][0]);
            //Console.WriteLine();
            //bool res = IsValidSudoku(new char[][]{
            //new char[]{'.', '.', '.', '.', '.', '.', '5', '.', '.'},
            //new char[]{'.', '.', '.', '.', '.', '.', '.', '.', '.'},
            //new char[]{'.', '.', '.', '.', '.', '.', '.', '.', '.'},
            //new char[]{'9', '3', '.', '.', '2', '.', '4', '.', '.'},
            //new char[]{'.', '.', '7', '.', '.', '.', '3', '.', '.'},
            //new char[]{'.', '.', '.', '.', '.', '.', '.', '.', '.'},
            //new char[]{'.', '.', '.', '3', '4', '.', '.', '.', '.'},
            //new char[]{'.', '.', '.', '.', '.', '3', '.', '.', '.'},
            //new char[]{'.', '.', '.', '.', '.', '5', '2', '.', '.'}});

            //Console.WriteLine(res);

            //Rotate(new int[][] { new int[] { 1, 2, 3 },
            //                     new int[] {4,5,6},
            //                     new int[] {7,8,9 } });

            //ReverseString(new char[] { 'h', 'e', 'l', 'l', 'o' });

            //Console.WriteLine(Reverse(536));

            //Console.WriteLine(FirstUniqChar("aadad"));

            //Console.WriteLine(IsAnagram("anagram", "nagaram"));

            //Console.WriteLine(IsPalindrome("0p"));

            //Console.WriteLine(MyAtoi("-91283472332"));

            //Console.WriteLine(StrStr("yes my name", "my"));

            //Console.WriteLine(CountAndSay(5));

            //Console.WriteLine(LongestCommonPrefix(new string[] { "sama", "saf", "sa"}));

            ListNode a1 = new ListNode(5, null);
            ListNode a2 = new ListNode(4, a1);
            ListNode a3 = new ListNode(3, a2);
            ListNode a4 = new ListNode(2, a3);
            ListNode a5 = new ListNode(1, a4);

            //Console.WriteLine(RemoveNthFromEnd(a2, 2));

            //ListNode isnull = new ListNode(5, null);
            //isnull = null;
            //Console.WriteLine(ReverseList(a5));

            //ListNode b1 = new ListNode(4, null);
            //ListNode b2 = new ListNode(2, b1);
            //ListNode b3 = new ListNode(1, b2);

            //ListNode c1 = new ListNode(3, null);
            //ListNode c2 = new ListNode(2, c1);
            //ListNode c3 = new ListNode(1, c2);

            ////MergeTwoLists(b3, c3);

            //ListNode d1 = new ListNode(1, null);
            //ListNode d2 = new ListNode(2, d1);
            //ListNode d3 = new ListNode(2, d2);
            //ListNode d4 = new ListNode(2, d3);
            //ListNode d5 = new ListNode(1, d4);

            //d1.next = d3;
            //Console.WriteLine(IsPalindrome(d5));

            //Console.WriteLine(HasCycle(d5));

            TreeNode t1 = new TreeNode(3);
            TreeNode t2 = new TreeNode(3, t1, null);
            TreeNode t3 = new TreeNode(3);
            TreeNode t4 = new TreeNode(3);
            TreeNode t5 = new TreeNode(3, t3, t2);
            TreeNode t6 = new TreeNode(3);
            TreeNode t7 = new TreeNode(3);
            TreeNode t8 = new TreeNode(8, t5, t4);
            TreeNode t9 = new TreeNode(12, t7, t6);
            TreeNode t10 = new TreeNode(3, t8, t9);

            //Console.WriteLine(IsValidBST(t2));

            TreeNode t11 = new TreeNode(3);
            TreeNode t12 = new TreeNode(1);
            TreeNode t13 = new TreeNode(2, t12, t11);

            TreeNode ch = new TreeNode(3);
            ch.left = new TreeNode(9);
            ch.right = new TreeNode(20);
            ch.right.left = new TreeNode(15);
            ch.right.right = new TreeNode(7);
            //Console.WriteLine(IsValidBST(t13));

            //LevelOrder(ch);

            //int[] arr = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //SortedArrayToBST(arr);

            //Merge(new int[] { 0 }, 0, new int[] { 1 }, 1);

            //FirstBadVersion(5);

            //MaxProfit2(new int[] { 7, 2, 6, 3, 10, 4 });

            //MaxSummary(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });

            //Rob(new int[] { 2, 7, 9, 3, 1 });

            ////Console.WriteLine(CountPrimes(10));
            //Console.WriteLine(ThreeSum(new int[] { -1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4 }));
            ListNode v5 = new ListNode(5, null);
            ListNode v4 = new ListNode(4, v5);
            ListNode v3 = new ListNode(3, v4);
            ListNode v2 = new ListNode(2, v3);
            ListNode v1 = new ListNode(1, v2);
            OddEvenList(v1);
            //Console.WriteLine(NextLargerNodes(v3));
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
            //////Too slow
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
            //if (nums.Length == 1) return nums[0];
            //Array.Sort(nums);
            //int save = nums[0];
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    if (nums[i] == nums[i + 1]) {
            //        save = nums[i + 1];
            //        continue;
            //    } 
            //    if (i == nums.Length - 2) return nums[i + 1];
            //    if (i == 0 && nums[i] != nums[i + 1]) return nums[i];
            //    if(save != nums[i+1] && nums[i+1] != nums[i+2]) return nums[i + 1];
            //}
            //return 0;

            int res = 0;
            foreach (var n in nums)
            {
                res = res ^ n;
            }
            return res;
        }

        //Given two arrays, write a function to compute their intersection.
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            int[] arr = new int[nums1.Length];
            int itemarr = 0;
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i = 0; int j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] == nums2[j])
                {
                    arr[itemarr++] = nums1[i++];
                    j++;
                }
                else if (nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            int[] arr2 = new int[itemarr];
            for (int b = 0; b < arr2.Length; b++)
            {
                arr2[b] = arr[b];
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            return arr2;
        }

        //Given a non-empty array of digits representing a non-negative integer, increment one to the integer.
        //The digits are stored such that the most significant digit is at the head of the list, and each element in the array contains a single digit.
        //You may assume the integer does not contain any leading zero, except the number 0 itself.
        public static int[] PlusOne(int[] digits)
        {
            //Dont handle large arrays
            //string numb = "";
            //foreach (var item in digits)
            //{
            //    numb += item.ToString();
            //}
            //int number = Convert.ToInt32(numb);
            //number++;
            //int[] arr = new int[number.ToString().Length];
            //int i= 0;
            //foreach (var item in number.ToString())
            //{
            //    arr[i] = Convert.ToInt32(item) - 48;
            //    i++;
            //}
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            //return arr;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] == 9 && i == 0)
                {
                    digits[i] = 0;
                    int[] arr = new int[digits.Length + 1];
                    arr[0] = 1;
                    for (int k = 1; k < arr.Length; k++)
                    {
                        arr[k] = digits[k - 1];
                    }
                    return arr;
                }
                else if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i]++;
                    break;
                }
            }
            foreach (var item in digits)
            {
                Console.WriteLine(item);
            }
            return digits;
        }

        //Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        public static void MoveZeroes(int[] nums)
        {
            int iszero = 0;
            for (int i = 0; i < nums.Length - iszero; i++)
            {
                if (nums[i] != 0) continue;
                for (int k = i; k < nums.Length - 1; k++)
                {
                    nums[k] = nums[k + 1];
                    nums[k + 1] = 0;
                }
                iszero++;
                i--;
            }
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int k = i; k < nums.Length - 1; k++)
                {
                    if (nums[i] + nums[k + 1] == target)
                    {
                        result[0] = i;
                        result[1] = k + 1;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            return result;
        }

        //Determine if a 9x9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
        //Each row must contain the digits 1-9 without repetition.
        //Each column must contain the digits 1-9 without repetition.
        //Each of the 9 3x3 sub-boxes of the grid must contain the digits 1-9 without repetition.
        public static bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (ContainsDuplicateInSudoku(board[i])) return false;
            }
            for (int k = 0; k < 9; k++)
            {
                if (ContainsDuplicateInSudoku(new char[]{ board[0][k],
                                                          board[1][k],
                                                          board[2][k],
                                                          board[3][k],
                                                          board[4][k],
                                                          board[5][k],
                                                          board[6][k],
                                                          board[7][k],
                                                          board[8][k]})) return false;
            }
            int m = 0;
            int n = 0;
            for (int iter = 1; iter <= 9; iter++)
            {
                if (ContainsDuplicateInSudoku(new char[]{   board[n][m],
                                                            board[n][m + 1],
                                                            board[n][m + 2],
                                                            board[n + 1][m],
                                                            board[n + 1][m + 1],
                                                            board[n + 1][m + 2],
                                                            board[n + 2][m],
                                                            board[n + 2][m + 1],
                                                            board[n + 2][m + 2]})) return false;
                if (iter % 3 == 0 && iter != 0)
                {
                    n += 3;
                    m = 0;
                }
                else
                {
                    m += 3;
                }
            }
            return true;
        }

        //Handle method for IsValidSudoku
        public static bool ContainsDuplicateInSudoku(char[] nums)
        {
            char[] copy = new char[9];
            nums.CopyTo(copy, 0);
            Array.Sort(copy);
            for (int i = 0; i < copy.Length - 1; i++)
            {
                if ((copy[i] == copy[i + 1]) && copy[i] != '.') return true;
            }
            return false;
        }

        //You are given an n x n 2D matrix representing an image.
        //Rotate the image by 90 degrees(clockwise).
        //Note:
        //You have to rotate the image in-place, which means you have to modify the input 2D matrix directly.DO NOT allocate another 2D matrix and do the rotation.
        public static void Rotate(int[][] matrix)
        {
            //later
            Console.WriteLine(matrix.Length * (matrix.GetUpperBound(0) + 1));
            for (int d = 0; d < matrix.Length; d++)
            {
                for (int m = 0; m < matrix.Length; m++)
                {
                    Console.Write("{0} ", String.Join(" ", matrix[d][m]));
                }
                Console.Write("\n");
            }

            //Write a function that reverses a string. The input string is given as an array of characters char[].
            //Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
            //You may assume all the characters consist of printable ascii characters.

        }
        public static void ReverseString(char[] s)
        {
            if (s.Length > 1)
            {
                char save1;
                for (int i = 0; i < s.Length / 2; i++)
                {
                    save1 = s[i];
                    s[i] = s[s.Length - i - 1];
                    s[s.Length - i - 1] = save1;
                }
            }

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }

        //Given a 32-bit signed integer, reverse digits of an integer.
        public static int Reverse(int x)
        {
            if (x.ToString().Length < 2) return x;
            string s = x.ToString();
            bool minus = false;
            if (s[0] == '-')
            {
                minus = true;
                s = s.Substring(1);
            }
            char save1;
            char save2;
            int m = (s.Length / 2 > 1) ? s.Length / 2 : s.Length - 1;
            for (int i = 0; i < m; i++)
            {
                save1 = s[s.Length - i - 1];
                save2 = s[i];
                s = s.Remove(s.Length - i - 1, 1);
                s = s.Insert(s.Length - i, save2.ToString());
                s = s.Remove(i, 1);
                s = s.Insert(i, save1.ToString());
            }
            if (minus) s = s.Insert(0, "-");
            int res = 0;
            Int32.TryParse(s, out res);
            return res;
        }

        //Given a string, find the first non-repeating character in it and return its index. If it doesn't exist, return -1.
        public static int FirstUniqChar(string s)
        {
            if (s.Length == 1) return 0;
            int flag;
            for (int i = 0; i < s.Length; i++)
            {
                flag = 0;
                for (int k = 1; k < s.Length; k++)
                {
                    if (s[i] == s[k]) break;
                    if (k == s.Length - 1) return i;
                }
            }
            return -1;
        }

        //Given two strings s and t , write a function to determine if t is an anagram of s.
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            //set the counter for values 
            int[] arr = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                arr[s[i] - 'a']++;
                arr[t[i] - 'a']--;
            }

            foreach (int count in arr)
            {
                if (count != 0)
                    return false;
            }

            return true;
        }

        //Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0) return true;
            int k = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (!Char.IsLetterOrDigit(s[i])) continue;
                if (!Char.IsLetterOrDigit(s[k]))
                {
                    k--;
                    i--;
                    continue;
                }
                if (Char.ToLower(s[i]) != Char.ToLower(s[k])) return false;
                k--;
            }
            return true;
        }

        //Implement atoi which converts a string to an integer.
        //The function first discards as many whitespace characters as necessary until the first non-whitespace character is found.Then, starting from this character,
        //takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.
        //The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.
        public static int MyAtoi(string str)
        {
            str = str.Trim();
            int flag = 0;
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (flag == 0 && (str[i] == '-' || str[i] == '+'))
                {
                    result += str[i];
                    flag++;
                    continue;
                }
                if ((Char.IsDigit(str[i])) && (flag == 0 || flag == 1))
                {
                    result += str[i];
                    flag = 1;
                }
                else break;
            }
            if (result == "" || result == "+" || result == "-") return 0;
            int res = 0;
            int check = 0;
            Int32.TryParse(result, out res);
            res = Int32.TryParse(result, out check) ? check : 1;
            if (res == check) return res;
            else if (result[0] == '-') return Int32.MinValue;
            else return Int32.MaxValue;
        }

        //Implement strStr().
        //Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
        public static int StrStr(string haystack, string needle)
        {
            if (needle == "") return 0;
            if (needle.Length > haystack.Length) return -1;
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length) == needle) return i;
            }
            return -1;
        }

        //The count-and-say sequence is the sequence of integers with the first five terms as following:
        //1.     1
        //2.     11
        //3.     21
        //4.     1211
        //5.     111221
        //1 is read off as "one 1" or 11.
        //11 is read off as "two 1s" or 21.
        //21 is read off as "one 2, then one 1" or 1211.
        //1 ≤ n ≤ 30
        public static string CountAndSay(int n)
        {
            if (n == 1) return "1";
            string str = CountAndSay(n - 1);
            int iter = 0;
            char save = str[0];
            var result = new StringBuilder();  //with StringBuilder result dont overwriting
            for (int i = 0; i < str.Length; i++)
            {
                if (save == str[i])
                {
                    iter++;
                    continue;
                }
                else
                {
                    result.Append(iter.ToString());
                    result.Append(save);
                    save = str[i];
                    iter = 1;
                }
            }
            result.Append(iter.ToString());
            result.Append(save);
            return result.ToString();
        }

        //Write a function to find the longest common prefix string amongst an array of strings.
        //If there is no common prefix, return an empty string "".
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];
            int minlen = strs[0].Length;
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].Length < minlen) minlen = strs[i].Length;
            }
            var result = new StringBuilder();


            for (int i = 0; i < minlen; i++)
            {
                for (int k = 0; k < strs.Length - 1; k++)
                {
                    if (strs[k][i] != strs[k + 1][i]) return result.ToString();
                }
                result.Append(strs[0][i]);
            }
            return result.ToString();
        }

        //Write a function to delete a node (except the tail) in a singly linked list, given only access to that node.
        //Given linked list -- head = [4,5,1,9], which looks like following:
        /**
        * Definition for singly-linked list.
        * public class ListNode {
        *     public int val;
        *     public ListNode next;
        *     public ListNode(int x) { val = x; }
        * }
        */
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

        //Given a linked list, remove the n-th node from the end of list and return its head.
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            //double pass algor

            //ListNode iter = head;
            //int len = 0;
            //while(iter != null)
            //{
            //    iter = iter.next;
            //    len++;
            //}
            //if (len == 1) return null;
            //ListNode dummy = new ListNode(0, head);
            //iter = dummy;
            //int del = len - n;
            //while(del > 0)
            //{
            //    del--;
            //    iter = iter.next;
            //}
            //iter.next = iter.next.next;
            //return dummy.next;

            //one pass algor
            ListNode save = new ListNode(0, head);
            ListNode first = save;
            ListNode second = save;
            for (int i = 0; i < n; i++)
            {
                first = first.next;
            }
            while (first.next != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return save.next;
        }

        //Reverse a singly linked list.
        public static ListNode ReverseList(ListNode head)
        {
            //Recurcive

            //if (head.next == null || head == null) return null;
            //ListNode save = head;
            //ListNode dummy = new ListNode(0, head);
            //while(head.next.next != null)
            //{
            //    head = head.next;
            //}
            //save = head.next;
            //head.next = head.next.next;
            //return new ListNode(save.val, ReverseList(dummy.next));

            //
            ListNode save = null;
            while (head != null)
            {
                save = new ListNode(head.val, save);
                head = head.next;
            }
            return save;
        }

        //Merge two sorted linked lists and return it as a new sorted list. 
        //The new list should be made by splicing together the nodes of the first two lists.
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0, null);
            ListNode dummy = result;
            while (l1 != null && l2 != null)
            {
                if (l1.val >= l2.val)
                {
                    result.next = l2;
                    result = result.next;
                    l2 = l2.next;
                }
                else
                {
                    result.next = l1;
                    result = result.next;
                    l1 = l1.next;
                }
            }
            if (l1 != null) result.next = l1;
            if (l2 != null) result.next = l2;
            return result;
        }

        //Given a singly linked list, determine if it is a palindrome.
        public static bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;
            Stack<int> stack = new Stack<int>();
            ListNode dummy = new ListNode(0, head);
            int len = 0;
            while (head != null)
            {
                len++;
                head = head.next;
            }
            head = dummy.next;
            ListNode prev = dummy.next;
            int iter = 0;
            while (iter < len / 2)
            {
                iter++;
                head = head.next;
            }
            if (len % 2 != 0)
            {
                iter++;
                head = head.next;
            }
            for (int i = 0; i < len / 2; i++)
            {
                stack.Push(prev.val);
                prev = prev.next;
            }
            int save;
            while (head != null)
            {
                save = stack.Pop();
                if (save != head.val) return false;
                head = head.next;
            }
            return true;
        }

        //Given a linked list, determine if it has a cycle in it.
        //To represent a cycle in the given linked list, we use an integer pos which represents the position(0-indexed) in the linked list where tail connects to.
        //If pos is -1, then there is no cycle in the linked list.
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;
            ListNode slow = head;
            ListNode fast = head.next;
            while (fast != slow)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }

        //Given a binary tree, find its maximum depth.
        //The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        //Note: A leaf is a node with no children.
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            // Recursively find the depth of each subtree.
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);

            // Get the larger depth and add 1 to it to
            // account for the root.
            if (leftDepth > rightDepth)
                return (leftDepth + 1);
            else
                return (rightDepth + 1);
        }

        //Given a binary tree, determine if it is a valid binary search tree(BST).
        //Assume a BST is defined as follows:
        //The left subtree of a node contains only nodes with keys less than the node's key.
        //The right subtree of a node contains only nodes with keys greater than the node's key.
        //Both the left and right subtrees must also be binary search trees.
        public static bool IsValidBST(TreeNode root)
        {
            if (root == null)
                return true;

            if (root.left != null && root.left.val > root.val) return false;
            if (root.right != null && root.right.val < root.val) return false;
            if ((root.left == null && root.right != null) || (root.left != null && root.right == null)) return false;

            bool leftroot = IsValidBST(root.left);
            bool rightroot = IsValidBST(root.right);

            return leftroot && rightroot ? true : false;
        }

        //Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
        public static bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        public static bool IsMirror(TreeNode r1, TreeNode r2)
        {
            if (r1 == null && r2 == null) return true;
            if (r1 == null || r2 == null) return false;
            if (r1.val != r2.val) return false;
            return IsMirror(r1.left, r2.right) && IsMirror(r1.right, r2.left);
        }

        //Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (root == null) return result;
            List<int> current = new List<int>();
            List<TreeNode> nodes = new List<TreeNode>();
            nodes.Add(root);
            current.Add(root.val);
            result.Add(current);
            int many;
            while (nodes.Count != 0)
            {
                current = new List<int>();
                many = nodes.Count;
                for (int i = 0; i < many; i++)
                {
                    if (nodes[0].left != null)
                    {
                        current.Add(nodes[0].left.val);
                        nodes.Add(nodes[0].left);
                    }
                    if (nodes[0].right != null)
                    {
                        current.Add(nodes[0].right.val);
                        nodes.Add(nodes[0].right);
                    }
                    nodes.Remove(nodes[0]);
                }
                if (current.Count > 0) result.Add(current);
            }
            return result;
        }

        //Given an array where elements are sorted in ascending order, convert it to a height balanced BST.
        //For this problem, a height-balanced binary tree is defined as a binary tree in which the depth of the two subtrees of every node never differ by more than 1.
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return BST(nums, 0, nums.Length - 1);
        }

        public static TreeNode BST(int[] arr, int start, int end)
        {
            /* Base Case */
            if (start > end)
            {
                return null;
            }

            /* Get the middle element and make it root */
            int mid = (start + end) / 2;
            TreeNode node = new TreeNode(arr[mid]);

            /* Recursively construct the left subtree and make it  
             left child of root */
            node.left = BST(arr, start, mid - 1);

            /* Recursively construct the right subtree and make it  
             right child of root */
            node.right = BST(arr, mid + 1, end);

            return node;
        }

        //Given two sorted integer arrays nums1 and nums2, merge nums2 into nums1 as one sorted array.
        //Note:
        //The number of elements initialized in nums1 and nums2 are m and n respectively.
        //You may assume that nums1 has enough space (size that is equal to m + n) to hold additional elements from nums2.
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[m + n - 1] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[m + n - 1] = nums2[n - 1];
                    n--;
                }
            }

            while (n > 0)
            {
                nums1[m + n - 1] = nums2[n - 1];
                n--;
            }
        }

        //You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check.
        //Since each version is developed based on the previous version, all the versions after a bad version are also bad.
        //Suppose you have n versions[1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
        //You are given an API bool isBadVersion(version) which will return whether version is bad.Implement a function to find the first bad version.
        //You should minimize the number of calls to the API.
        public static int FirstBadVersion(int n)
        {
            //int save = n / 2;
            //int fix = n / 2;
            //int save2 = -1;
            //int save3 = n / 2;
            //int result = 0;
            //while (save2 != save)
            //{
            //    save2 = save;
            //    if (IsBadVersion(save) == true)
            //    {
            //        result = save;
            //        save -= fix;
            //    }
            //    else save += fix;
            //    fix = fix/2;
            //}
            //return result;

            int middle = n / 2;
            int end = n;
            int result = 0;
            int save = n;
            while(middle != save)
            {
                save = middle;
                if(IsBadVersion(middle))
                {
                    result = middle;
                    end = middle - 1;
                    middle = end / 2 + 1;
                }
                else
                {
                    middle = (middle + end) / 2;
                }
            }
            return result;
         }

        public static bool IsBadVersion(int n)
        {
            return n >= 4 ? true : false;
        }

        //You are climbing a stair case. It takes n steps to reach to the top.
        //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?
        public static int ClimbStairs(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            int result = 2;
            int prevresult = 1;
            int save = 0;
            for (int i = 2; i < n + 1; i++)
            {
                save = prevresult;
                result = result + prevresult;
                prevresult = result - save;
            }
            return result;
        }

        //Say you have an array for which the ith element is the price of a given stock on day i.

        //If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock),
        //design an algorithm to find the maximum profit.
        public static int MaxProfit2(int[] prices)
        {
            //Base on MaxProfit1

            //int min = Int32.MaxValue;
            //int max = 0;
            //int result1 = 0;
            //int result2 = 0;
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    if (i + 1 >= prices.Length)
            //    {
            //        break;
            //    }

            //    while (prices[i] >= prices[i + 1])
            //    {
            //        i++;
            //        if (i + 1 >= prices.Length)
            //        {
            //            return result1;
            //            i--;
            //            break;
            //        }
            //    }
            //    if (prices[i] < prices[i + 1]) min = prices[i] < min ? prices[i] : min;

            //    while (prices[i] <= prices[i + 1])
            //    {
            //        i++;
            //        if (i + 1 >= prices.Length)
            //        {
            //            max = prices[i];
            //            i--;
            //            break;
            //        }

            //    }
            //    if (prices[i] > prices[i + 1]) max = prices[i];
            //    if (result1 == 0) result1 = max - min;
            //    else
            //    {
            //        result2 = max - min;
            //        result1 = result2 > result1 ? result2 : result1;
            //    }

            //}
            //return result1;


            //Better solution)
            int min = Int32.MaxValue;
            int result = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    continue;
                }
                else
                {
                    result = prices[i] - min > result ? prices[i] - min : result;
                }
            }
            return result;
        }

        public static int MaxSummary(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }

        //You are a professional robber planning to rob houses along a street. 
        //Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them is that adjacent
        //houses have security system connected and it will automatically contact the police if two adjacent houses were broken into on the same night.
        //Solution with Tree (bad)
        //public static int Rob(int[] nums)
        //{
        //    if (nums.Length == 0) return 0;
        //    TreeNode node;
        //    int result1;
        //    int result2 = 0;
        //    (node,result1) = TreeRob(nums, 0, 0);
        //    if(nums.Length > 1)
        //        (node, result2) = TreeRob(nums, 1, 0);
        //    return Math.Max(result1,result2);
        //}

        //public static (TreeNode, int) TreeRob(int[] nums, int start, int sum)
        //{
        //    TreeNode node = new TreeNode(nums[start] + sum);
        //    sum = nums[start] + sum;
        //    int result1 = 0;
        //    int result2 = 0;
        //    int result = node.val;

        //    if (start + 2 < nums.Length)
        //        (node.left,result1) = TreeRob(nums, start + 2, sum);

        //    if (start + 3 < nums.Length)
        //        (node.right, result2) = TreeRob(nums, start + 3, sum);

        //    result = Math.Max(result, Math.Max(result1, result2));
        //    return (node, result);
        //}

        //Best solution
        public static int Rob(int[] nums)
        {
            int n = nums.Length;
            if (n == 0)
                return 0;

            int value1 = nums[0];
            if (n == 1)
                return value1;

            int value2 = Math.Max(nums[0], nums[1]);
            if (n == 2)
                return value2;

            // contains maximum stolen value at the end 
            int max_val = 0;

            // Fill remaining positions 
            for (int i = 2; i < n; i++)
            {
                max_val = Math.Max(nums[i] + value1, value2);
                value1 = value2;
                value2 = max_val;
            }

            return max_val;
        }

        //Write a program that outputs the string representation of numbers from 1 to n.
        //But for multiples of three it should output “Fizz” instead of the number 
        //and for the multiples of five output “Buzz”. For numbers which are multiples of both three and five output “FizzBuzz”.
        public static IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();
            string push = "";
            for (int i = 1; i <= n; i++)
            {
                push = "";
                if (i % 3 == 0) push += "Fizz";
                if(i % 5 == 0) push += "Buzz";
                if (push == "") push = i.ToString();
                result.Add(push);
            }
            return result;
        }

        //Count the number of prime numbers less than a non-negative number, n.
        public static int CountPrimes(int n)
        {
            bool[] isPrime = new bool[n];
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }
            // Loop's ending condition is i * i < n instead of i < sqrt(n)
            // to avoid repeatedly calling an expensive function sqrt().
            for (int i = 2; i * i < n; i++)
            {
                if (!isPrime[i]) continue;
                for (int j = i * i; j < n; j += i)
                {
                    isPrime[j] = false;
                }
            }
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i]) count++;
            }
            return count;
        }

        //The Hamming distance between two integers is the number of positions at which the corresponding bits are different.
        //Given two integers x and y, calculate the Hamming distance.
        public static int HammingDistance(int x, int y)
        {
            int xoy = x ^ y;
            string xb = Convert.ToString(x, 2);
            string yb = Convert.ToString(y, 2);
            int result = 0;
            StringBuilder max = new StringBuilder(xb.Length >= yb.Length ? xb : yb);
            StringBuilder min = new StringBuilder(xb.Length < yb.Length ? xb : yb);
            while(min.Length != max.Length)
            {
                min.Insert(0, '0');
            }

            for (int i = 0; i < max.Length; i++)
            {
                if (max[i] != min[i]) result++;
            }
            return result;
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            //O(n^3)
            List<int> origin = nums.ToList<int>();
            origin.Sort();
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int n = i + 1; n < nums.Length; n++)
                {
                    for (int s = n + 1; s < nums.Length; s++)
                    {
                        if (origin[i] == -(origin[n] + origin[s]))
                        {
                            result.Add(new List<int> { origin[i], origin[n], origin[s] });
                            result[result.Count - 1].Sort();
                            
                        }
                    }
                }
            }
            for (int i = 2; i <= result.Count; i++)
            {
                for (int n = 2; n <= result.Count; n++)
                {
                    if (result.Count > 1 && i - 1 != n &&
                    result[n - 1][0] == result[i - 2][0] &&
                    result[n - 1][1] == result[i - 2][1] &&
                    result[n - 1][2] == result[i - 2][2])
                    {
                        result.RemoveAt(n - 1);
                        n--;
                    }
                }
            }
            result.Union<IList<int>>(result);
            return result.ToList<IList<int>>();
        }

        //Given head which is a reference node to a singly-linked list. 
        //The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.
        public static int GetDecimalValue(ListNode head)
        {
            ListNode dummy = new ListNode(0, head);
            int count = -1;
            double result = 0;
            while (head != null)
            {
                count += 1;
                head = head.next;
            }
            dummy = dummy.next;
            while(dummy != null)
            {
                if(dummy.val == 1)
                {
                    result += Math.Pow(2, count);
                }
                count--;
                dummy = dummy.next;
            }
            return Convert.ToInt32(result);
        }

        //Given a non-empty, singly linked list with head node head, return a middle node of linked list.
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode dummy = new ListNode(0, head);
            int size = 0;
            while(head != null)
            {
                size++;
                head = head.next;
            }
            size = size / 2 + 1;
            dummy = dummy.next;
            for (int i = 0; i < size; i++)
            {
                dummy = dummy.next;
            }
            return dummy;
        }

        //We are given a linked list with head as the first node.  Let's number the nodes in the list: node_1, node_2, node_3, ... etc.
        //Each node may have a next larger value: for node_i, next_larger(node_i) is the node_j.val such that j > i, node_j.val > node_i.val, 
        //and j is the smallest possible choice.  If such a j does not exist, the next larger value is 0.
        public static int[] NextLargerNodes(ListNode head)
        {
            ListNode dummy = new ListNode(0, head);
            int size = 0;
            while(head != null)
            {
                ListNode current = new ListNode(0, head);
                while (true)
                {
                    if (head.next != null && head.next.val > current.next.val) 
                    {
                        current.next.val = head.next.val;
                        break;
                    }
                    else if (head.next != null) head = head.next;
                    else
                    {
                        current.next.val = 0;
                        break;
                    };
                }
                head = current.next.next;
                size++;
            }
            int[] result = new int[size];
            dummy = dummy.next;
            int i = 0;
            while (dummy != null)
            {
                result[i] = dummy.val;
                dummy = dummy.next;
                i++;
            }
            return result;
        }

        //We are given head, the head node of a linked list containing unique integer values.
        //We are also given the list G, a subset of the values in the linked list.
        //Return the number of connected components in G, where two values are connected if they appear consecutively in the linked list.
        public static int NumComponents(ListNode head, int[] G)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in G)
            {
                set.Add(item);
            }
            int result = 0;
            while(head != null)
            {
                if (set.Contains(head.val) &&
                    (head.next == null || !set.Contains(head.next.val))) result++;
               head = head.next;
            }
            return result;
        }

        //Given a singly linked list, group all odd nodes together followed by the even nodes.
        //Please note here we are talking about the node number and not the value in the nodes.
        public static ListNode OddEvenList(ListNode head)
        {
            ListNode result = new ListNode(head.val, null);
            ListNode dummy = new ListNode(0, result);
            ListNode dinamic = head;
            while (dinamic != null && dinamic.next != null && dinamic.next.next != null)
            {
                result.next = new ListNode(dinamic.next.next.val, null);
                result = result.next;
                dinamic = dinamic.next.next;
            }
            dinamic = new ListNode(0, head);
            while (dinamic != null && dinamic.next != null && dinamic.next.next != null)
            {
                result.next = new ListNode(dinamic.next.next.val, null);
                result = result.next;
                dinamic = dinamic.next.next;
            }
            return dummy.next;
        }
    }

    public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }


        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
    
}