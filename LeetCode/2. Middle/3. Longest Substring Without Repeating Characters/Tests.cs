using NUnit.Framework;

namespace LeetCode._2._Middle._3._Longest_Substring_Without_Repeating_Characters;

[TestFixture(TestName = "3. Longest Substring Without Repeating Characters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcabcbb", 3)]
    [TestCase("bbbbb", 1)]
    [TestCase("pwwkew", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LengthOfLongestSubstring(input);
        Assert.AreEqual(output, actual);
    }
}