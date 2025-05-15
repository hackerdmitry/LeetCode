using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2900._Longest_Unequal_Adjacent_Groups_Subsequence_I;

[TestFixture(TestName = "2900. Longest Unequal Adjacent Groups Subsequence I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"e\",\"a\",\"b\"]", "[0,0,1]", "[\"e\",\"b\"]")]
    [TestCase("[\"a\",\"b\",\"c\",\"d\"]", "[1,0,1,1]", "[\"a\",\"b\",\"c\"]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.GetLongestSubsequence(input1.ParseStringArray(), input2.ParseIntArray());
        Assert.AreEqual(output.ParseStringArray(), actual);
    }
}
