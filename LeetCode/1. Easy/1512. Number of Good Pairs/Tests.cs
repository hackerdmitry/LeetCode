using NUnit.Framework;

namespace LeetCode._1512._Number_of_Good_Pairs
{
    [TestFixture(TestName = "1512. Number of Good Pairs")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] { 1, 2, 3, 1, 1, 3 }, 4)]
        [TestCase(new[] { 1, 1, 1, 1 }, 6)]
        [TestCase(new[] { 1, 2, 3 }, 0)]
        public void Test(int[] input, int output)
        {
            var solution = new Solution();
            var actual = solution.NumIdenticalPairs(input);
            Assert.AreEqual(output, actual);
        }
    }
}