using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3719._Longest_Balanced_Subarray_I;

[TestFixture(TestName = "3719. Longest Balanced Subarray I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,2]", 3)]
    [TestCase("[2,5,4,3]", 4)]
    [TestCase("[3,2,2,5,4]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestBalanced(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
