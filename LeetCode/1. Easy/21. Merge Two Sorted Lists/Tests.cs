using System;
using System.Collections.Generic;
using System.Linq;
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
            var solution = new Solution();

            var list1 = input1.Reverse().Aggregate((ListNode) null, (nextNode, curValue) => new ListNode(curValue, nextNode));
            var list2 = input2.Reverse().Aggregate((ListNode) null, (nextNode, curValue) => new ListNode(curValue, nextNode));

            var result = solution.MergeTwoLists(list1, list2);

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