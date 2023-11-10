using NUnit.Framework;

namespace LeetCode._1._Easy._746._Min_Cost_Climbing_Stairs
{
    [TestFixture(TestName = "746. Min Cost Climbing Stairs")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] { 10, 15, 20 }, 15)]
        [TestCase(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }, 6)]
        [TestCase(new[] { 999, 10, 15, 20 }, 25)]
        public void Test(int[] input, int output)
        {
            var solution = new Solution();
            var actual = solution.MinCostClimbingStairs(input);
            Assert.AreEqual(output, actual);
        }
    }
}