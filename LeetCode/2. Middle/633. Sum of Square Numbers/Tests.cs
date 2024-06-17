using NUnit.Framework;

namespace LeetCode._2._Middle._633._Sum_of_Square_Numbers;

[TestFixture(TestName = "633. Sum of Square Numbers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, true)]
    [TestCase(3, false)]
    [TestCase(10000, true)]
    [TestCase(8, true)]
    [TestCase(2147483641, false)]
    public void Test(int input, bool output)
    {
        var solution = new Solution();
        var actual = solution.JudgeSquareSum(input);
        Assert.AreEqual(output, actual);
    }
}