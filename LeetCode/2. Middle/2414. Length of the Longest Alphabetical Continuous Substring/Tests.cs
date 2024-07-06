using NUnit.Framework;

namespace LeetCode._2._Middle._2414._Length_of_the_Longest_Alphabetical_Continuous_Substring;

[TestFixture(TestName = "2414. Length of the Longest Alphabetical Continuous Substring")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("awy", 1)]
    [TestCase("abacaba", 2)]
    [TestCase("abcde", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestContinuousSubstring(input);
        Assert.AreEqual(output, actual);
    }
}
