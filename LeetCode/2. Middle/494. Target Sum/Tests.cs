using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._494._Target_Sum;

[TestFixture(TestName = "494. Target Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,0,0,0,0,0,0,0,1]", 1, 256)]
    [TestCase("[1,1,1,1,1]", 3, 5)]
    [TestCase("[1]", 1, 1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindTargetSumWays(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
