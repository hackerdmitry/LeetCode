using NUnit.Framework;

namespace LeetCode._2._Middle._1143._Longest_Common_Subsequence;

[TestFixture(TestName = "1143. Longest Common Subsequence")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcde", "ace", 3)]
    [TestCase("abc", "abc", 3)]
    [TestCase("abc", "def", 0)]
    [TestCase("acc", "acd", 2)]
    [TestCase("jgtargjctqvijshexyjcjcre", "pyzazexujqtsjebcnadahobwf", 6)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestCommonSubsequence(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
