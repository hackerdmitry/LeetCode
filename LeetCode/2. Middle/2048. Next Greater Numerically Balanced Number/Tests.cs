using NUnit.Framework;

namespace LeetCode._2._Middle._2048._Next_Greater_Numerically_Balanced_Number;

[TestFixture(TestName = "2048. Next Greater Numerically Balanced Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, 22)]
    [TestCase(1000, 1333)]
    [TestCase(3000, 3133)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.NextBeautifulNumber(input);
        Assert.AreEqual(output, actual);
    }
}
