using NUnit.Framework;

namespace LeetCode._2._Middle._838._Push_Dominoes;

[TestFixture(TestName = "838. Push Dominoes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("R.", "RR")]
    [TestCase(".L.R...LR..L..", "LL.RR.LLRRLL..")]
    [TestCase("RR.L", "RR.L")]
    [TestCase(".L", "LL")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.PushDominoes(input);
        Assert.AreEqual(output, actual);
    }
}