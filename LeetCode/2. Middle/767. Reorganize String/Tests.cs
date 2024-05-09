using NUnit.Framework;

namespace LeetCode._2._Middle._767._Reorganize_String;

[TestFixture(TestName = "767. Reorganize String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aab", "aba")]
    [TestCase("aaab", "")]
    [TestCase("aabbcc", "abcabc")]
    [TestCase("aaabbcc", "ababac")]
    [TestCase("aaaabbc", "ababaca")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ReorganizeString(input);
        Assert.AreEqual(output, actual);
    }
}
