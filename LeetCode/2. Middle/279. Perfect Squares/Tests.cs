using NUnit.Framework;

namespace LeetCode._2._Middle._279._Perfect_Squares;

[TestFixture(TestName = "279. Perfect Squares")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(12, 3)]
    [TestCase(13, 2)]
    [TestCase(44, 3)]
    [TestCase(7168, 4)]
    [TestCase(5756, 4)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumSquares(input);
        Assert.AreEqual(output, actual);
    }
}