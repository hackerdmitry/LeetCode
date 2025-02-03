using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3105._Longest_Strictly_Increasing_or_Strictly_Decreasing_Subarray;

[TestFixture(TestName = "3105. Longest Strictly Increasing or Strictly Decreasing Subarray")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,4,3,3,2]", 2)]
    [TestCase("[3,3,3,3]", 1)]
    [TestCase("[3,2,1]", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestMonotonicSubarray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
