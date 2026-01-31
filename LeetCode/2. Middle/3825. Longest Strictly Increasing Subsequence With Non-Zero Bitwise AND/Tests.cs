using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3825._Longest_Strictly_Increasing_Subsequence_With_Non_Zero_Bitwise_AND;

[TestFixture(TestName = "3825. Longest Strictly Increasing Subsequence With Non-Zero Bitwise AND")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,4,7]", 2)]
    [TestCase("[2,3,6]", 3)]
    [TestCase("[0,1]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestSubsequence(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
