using System;
using System.Collections.Generic;
using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._1._Easy._21._Merge_Two_Sorted_Lists
{
    [TestFixture(TestName = "21. Merge Two Sorted Lists")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] {1, 2, 4}, new[] {1, 3, 4}, new[] {1, 1, 2, 3, 4, 4})]
        [TestCase(new int[0], new int[0], new int[0])]
        [TestCase(new int[0], new[] {0}, new[] {0})]
        public void Test(int[] input1, int[] input2, int[] output)
        {
            var list1 = ListNode.CreateFromArray(input1);
            var list2 = ListNode.CreateFromArray(input2);

            var result = new Solution().MergeTwoLists(list1, list2);

            var actual = new List<int>();
            while (result != null)
            {
                actual.Add(result.val);
                result = result.next;
            }

            Console.WriteLine(string.Join(", ", output));
            Console.WriteLine(string.Join(", ", actual));
            Assert.AreEqual(output, actual);
        }
    }
}