using NUnit.Framework;

namespace LeetCode._1._Easy._342._Power_of_Four
{
    [TestFixture(TestName = "342. Power of Four")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(16, true)]
        [TestCase(5, false)]
        [TestCase(1, true)]
        [TestCase(-64, false)]
        public void Test(int input, bool output)
        {
            var solution = new Solution();
            var actual = solution.IsPowerOfFour(input);
            Assert.AreEqual(output, actual);
        }
    }
}