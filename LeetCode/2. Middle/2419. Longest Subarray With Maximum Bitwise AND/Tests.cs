using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2419._Longest_Subarray_With_Maximum_Bitwise_AND;

[TestFixture(TestName = "2419. Longest Subarray With Maximum Bitwise AND")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,3,2,2]", 2)]
    [TestCase("[1,2,3,4]", 1)]
    [TestCase("[1,4,3,4,4]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestSubarray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
