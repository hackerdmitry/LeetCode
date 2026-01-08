using NUnit.Framework;

namespace LeetCode._1._Easy._2485._Find_the_Pivot_Integer;

[TestFixture(TestName = "2485. Find the Pivot Integer")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(8, 6)]
    [TestCase(1, 1)]
    [TestCase(4, -1)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.PivotInteger(input);
        Assert.AreEqual(output, actual);
    }
}
