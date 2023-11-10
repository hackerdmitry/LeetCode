using NUnit.Framework;

namespace LeetCode._2._Middle._343._Integer_Break
{
    [TestFixture(TestName = "343. Integer Break")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 4)]
        [TestCase(10, 36)]
        public void Test(int input, int output)
        {
            var solution = new Solution();
            var actual = solution.IntegerBreak(input);
            Assert.AreEqual(output, actual);
        }
    }
}