using NUnit.Framework;

namespace LeetCode.Sample
{
    // Array regular expression: (?<=nums\d = \[).*?(?=\])

    [TestFixture(TestName = "Sample")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(1, 2, 3)]
        public void Test(int input1, int input2, int output)
        {
            var solution = new Solution();
            var actual = solution.Sum(input1, input2);
            Assert.AreEqual(output, actual);
        }
    }
}