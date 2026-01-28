using NUnit.Framework;

namespace LeetCode._3._Hard._224._Basic_Calculator;

[TestFixture(TestName = "224. Basic Calculator")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("(6)-(8)-(7)+(1+(6))", -2)]
    [TestCase("1 + 1", 2)]
    [TestCase(" 2-1 + 2 ", 3)]
    [TestCase("(1+(4+5+2)-3)+(6+8)", 23)]
    [TestCase("-(2 + 3)", -5)]
    [TestCase("-(-(2 + 3))", 5)]
    [TestCase("-7 + -3", -10)]
    [TestCase("8*((2+6)+(2-4))", 48)]
    [TestCase("(4+4)", 8)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.Calculate(input);
        Assert.AreEqual(output, actual);
    }
}
