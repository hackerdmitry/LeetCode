using NUnit.Framework;

namespace LeetCode._3._Hard._458._Poor_Pigs
{
    [TestFixture(TestName = "458. Poor Pigs")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(4, 15, 15, 2)]
        [TestCase(4, 15, 30, 2)]
        [TestCase(4, 15, 45, 1)]
        [TestCase(1000, 15, 60, 5)]
        [TestCase(27, 1, 2, 3)]
        [TestCase(1, 1, 1, 0)]
        public void Test(int input1, int input2, int input3, int output)
        {
            var solution = new Solution();
            var actual = solution.PoorPigs(input1, input2, input3);
            Assert.AreEqual(output, actual);
        }
    }
}