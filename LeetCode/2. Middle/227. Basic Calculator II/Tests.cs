using NUnit.Framework;

namespace LeetCode._2._Middle._227._Basic_Calculator_II;

[TestFixture(TestName = "227. Basic Calculator II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("1*2-3/4+5*6-7*8+9/10", -24)]
    [TestCase("3+2*2", 7)]
    [TestCase(" 3/2 ", 1)]
    [TestCase(" 3+5 / 2 ", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.Calculate(input);
        Assert.AreEqual(output, actual);
    }
}
