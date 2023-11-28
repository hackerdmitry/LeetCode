using NUnit.Framework;

namespace LeetCode._3._Hard._2147._Number_of_Ways_to_Divide_a_Long_Corridor;

[TestFixture(TestName = "2147. Number of Ways to Divide a Long Corridor")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("SSPPSPS", 3)]
    [TestCase("PPSPSP", 1)]
    [TestCase("S", 0)]
    [TestCase("PPSSPPSPSPPSSP", 9)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumberOfWays(input);
        Assert.AreEqual(output, actual);
    }
}
