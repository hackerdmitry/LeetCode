using NUnit.Framework;

namespace LeetCode._3._Hard._1458._Max_Dot_Product_of_Two_Subsequences
{
    [TestFixture(TestName = "1458. Max Dot Product of Two Subsequences")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] {2, 1, -2, 5}, new[] {3, 0, -6}, 18)]
        [TestCase(new[] {3, -2}, new[] {2, -6, 7}, 21)]
        [TestCase(new[] {-1, -1}, new[] {1, 1}, -1)]
        [TestCase(new[] {5, -4, -3}, new[] {-4, -3, 0, -4, 2}, 28)]
        [TestCase(new[] {7, 2, 2, -1, -1, 1, -4, 7, 6}, new[] {-7, -9, -1, 2, 2, 5, -7, 2, -7, 5}, 108)]
        public void Test(int[] input1, int[] input2, int output)
        {
            var solution = new Solution();
            var actual = solution.MaxDotProduct(input1, input2);
            Assert.AreEqual(output, actual);
        }
    }
}