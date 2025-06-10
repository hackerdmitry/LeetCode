using NUnit.Framework;

namespace LeetCode._1._Easy._3442._Maximum_Difference_Between_Even_and_Odd_Frequency_I;

[TestFixture(TestName = "3442. Maximum Difference Between Even and Odd Frequency I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aaaaabbc", 3)]
    [TestCase("abcabcab", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxDifference(input);
        Assert.AreEqual(output, actual);
    }
}
