using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3097._Shortest_Subarray_With_OR_at_Least_K_II;

[TestFixture(TestName = "3097. Shortest Subarray With OR at Least K II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,8]", 10, 3)]
    [TestCase("[1,2,3]", 2, 1)]
    [TestCase("[1,2]", 0, 1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumSubarrayLength(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}