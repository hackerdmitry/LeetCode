using NUnit.Framework;

namespace LeetCode._1._Easy._1496._Path_Crossing;

[TestFixture(TestName = "1496. Path Crossing")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("NES", false)]
    [TestCase("NESWW", true)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsPathCrossing(input);
        Assert.AreEqual(output, actual);
    }
}
