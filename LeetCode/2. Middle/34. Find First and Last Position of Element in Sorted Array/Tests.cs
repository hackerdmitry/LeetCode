using System;
using NUnit.Framework;

namespace LeetCode._34._Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    [TestFixture(TestName = "34. Find First and Last Position of Element in Sorted Array")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] { 5, 7, 7, 8, 8, 10 }, 8, new[] { 3, 4 })]
        [TestCase(new[] { 5, 7, 7, 8, 8, 10 }, 6, new[] { -1, -1 })]
        [TestCase(new int[0], 0, new[] { -1, -1 })]
        public void Test(int[] input1, int input2, int[] output)
        {
            var solution = new Solution();
            var actual = solution.SearchRange(input1, input2);
            Console.WriteLine("expected: " + string.Join(", ", output));
            Console.WriteLine("actual: " + string.Join(", ", actual));
            Assert.AreEqual(output, actual);
        }
    }
}