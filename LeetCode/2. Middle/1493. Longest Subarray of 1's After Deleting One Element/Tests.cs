using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1493._Longest_Subarray_of_1_s_After_Deleting_One_Element;

[TestFixture(TestName = "1493. Longest Subarray of 1's After Deleting One Element")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,0,1]", 3)]
    [TestCase("[0,1,1,1,0,1,1,0,1]", 5)]
    [TestCase("[1,1,1]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestSubarray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
