using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace LeetCode._2._Middle._2._Add_Two_Numbers
{
    [TestFixture(TestName = "2. Add Two Numbers")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 7, 0, 8 })]
        [TestCase(new[] { 0 }, new[] { 0 }, new[] { 0 })]
        [TestCase(new[] { 9, 9, 9, 9, 9, 9, 9 }, new[] { 9, 9, 9, 9 }, new[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void Test(int[] input1, int[] input2, int[] output)
        {
            var solution = new Solution();

            var list1 = input1
                .Reverse()
                .Aggregate((ListNode)null, (nextNode, curValue) => new ListNode(curValue, nextNode));
            var list2 = input2
                .Reverse()
                .Aggregate((ListNode)null, (nextNode, curValue) => new ListNode(curValue, nextNode));

            var result = solution.AddTwoNumbers(list1, list2);

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