using NUnit.Framework;

namespace LeetCode._2._Middle._2483._Minimum_Penalty_for_a_Shop;

[TestFixture(TestName = "2483. Minimum Penalty for a Shop")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("YYNY", 2)]
    [TestCase("NNNNN", 0)]
    [TestCase("YYYY", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.BestClosingTime(input);
        Assert.AreEqual(output, actual);
    }
}
