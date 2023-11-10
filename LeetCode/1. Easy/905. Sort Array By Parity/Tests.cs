using NUnit.Framework;

namespace LeetCode._905._Sort_Array_By_Parity
{
    [TestFixture(TestName = "905. Sort Array By Parity")]
    public class Tests
    {
        [TestCase(new[] {3, 1, 2, 4}, new[] {2, 4, 3, 1})]
        [TestCase(new[] {0}, new[] {0})]
        public void Test(int[] input, int[] output)
        {
            var solution = new Solution();
            var actual = solution.SortArrayByParity(input);
            Assert.AreEqual(output, actual);
        }
    }
}