using NUnit.Framework;

namespace LeetCode._2._Middle._649._Dota2_Senate;

[TestFixture(TestName = "649. Dota2 Senate")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("RD", "Radiant")]
    [TestCase("RDD", "Dire")]
    [TestCase("DDRRR", "Dire")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.PredictPartyVictory(input);
        Assert.AreEqual(output, actual);
    }
}
