using NUnit.Framework;

namespace LeetCode._2._Middle._229._Majority_Element_II
{
    [TestFixture(TestName = "229. Majority Element II")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(new[] { 3, 2, 3 }, new[] { 3 })]
        [TestCase(new[] { 1 }, new[] { 1 })]
        [TestCase(new[] { 1, 2 }, new[] { 1, 2 })]
        public void Test(int[] input, int[] output)
        {
            var solution = new Solution();
            var actual = solution.MajorityElement(input);
            Assert.AreEqual(output, actual);
        }
    }
}