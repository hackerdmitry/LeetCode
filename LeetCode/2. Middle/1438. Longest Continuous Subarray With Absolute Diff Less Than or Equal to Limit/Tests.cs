using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1438._Longest_Continuous_Subarray_With_Absolute_Diff_Less_Than_or_Equal_to_Limit;

[TestFixture(TestName = "1438. Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[8,2,4,7]", 4, 2)]
    [TestCase("[10,1,2,4,7,2]", 5, 4)]
    [TestCase("[4,2,2,2,4,4,2,2]", 0, 3)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestSubarray(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
