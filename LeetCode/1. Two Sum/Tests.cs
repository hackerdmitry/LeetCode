using System;
using NUnit.Framework;

namespace LeetCode._1._Two_Sum
{
    [TestFixture(TestName = "1. Two Sum")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] {2, 7, 11, 15}, 9, new[] {0, 1})]
        [TestCase(new[] {3, 2, 4}, 6, new[] {1, 2})]
        [TestCase(new[] {3, 3}, 6, new[] {0, 1})]
        public void Test(int[] input1, int input2, int[] output)
        {
            var solution = new Solution();
            var actual = solution.TwoSum(input1, input2);
            Console.WriteLine(string.Join(", ", actual));
            Assert.AreEqual(output, actual);
        }
    }
}