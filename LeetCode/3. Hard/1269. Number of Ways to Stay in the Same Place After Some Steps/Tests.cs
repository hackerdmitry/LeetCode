using NUnit.Framework;

namespace LeetCode._3._Hard._1269._Number_of_Ways_to_Stay_in_the_Same_Place_After_Some_Steps
{
    [TestFixture(TestName = "1269. Number of Ways to Stay in the Same Place After Some Steps")]
    public class Tests
    {
        [Timeout(1000)]
        [TestCase(3, 2, 4)]
        [TestCase(2, 4, 2)]
        [TestCase(4, 2, 8)]
        [TestCase(4, 4, 9)]
        public void Test(int input1, int input2, int output)
        {
            var solution = new Solution();
            var actual = solution.NumWays(input1, input2);
            Assert.AreEqual(output, actual);
        }
    }
}