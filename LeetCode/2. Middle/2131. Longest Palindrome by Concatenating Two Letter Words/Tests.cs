using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2131._Longest_Palindrome_by_Concatenating_Two_Letter_Words;

[TestFixture(TestName = "2131. Longest Palindrome by Concatenating Two Letter Words")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("['gg','or','dl','oo','oo']", 6)]
    [TestCase("['cc','ll','xx']", 2)]
    [TestCase("['lc','cl','gg']", 6)]
    [TestCase("['lc','sl','gg']", 2)]
    [TestCase("['gg','or','dl']", 2)]
    [TestCase("['gg','or','dl','oo']", 2)]
    [TestCase("['gg','or','dl','oo','oo','gg']", 8)]
    [TestCase("['lc','sl','gl']", 0)]
    [TestCase("['lc','cl','gl']", 4)]
    [TestCase("['lc','cl','gg','gg']", 8)]
    [TestCase("['ab','ty','yt','lc','cl','ab']", 8)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestPalindrome(input.ParseStringArray('\''));
        Assert.AreEqual(output, actual);
    }
}
