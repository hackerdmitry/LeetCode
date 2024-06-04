using NUnit.Framework;

namespace LeetCode._1._Easy._409._Longest_Palindrome;

[TestFixture(TestName = "409. Longest Palindrome")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abccccdd", 7)]
    [TestCase("a", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestPalindrome(input);
        Assert.AreEqual(output, actual);
    }
}