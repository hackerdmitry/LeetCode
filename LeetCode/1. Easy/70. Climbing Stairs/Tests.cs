using NUnit.Framework;

namespace LeetCode._1._Easy._70._Climbing_Stairs;

[TestFixture(TestName = "70. Climbing Stairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    [TestCase(45, 1836311903)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.ClimbStairs(input);
        Assert.AreEqual(output, actual);
    }
}
