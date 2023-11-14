using NUnit.Framework;

namespace LeetCode._2._Middle._1930._Unique_Length_3_Palindromic_Subsequences;

[TestFixture(TestName = "1930. Unique Length-3 Palindromic Subsequences")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aabca", 3)]
    [TestCase("adc", 0)]
    [TestCase("bbcbaba", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountPalindromicSubsequence(input);
        Assert.AreEqual(output, actual);
    }
}
