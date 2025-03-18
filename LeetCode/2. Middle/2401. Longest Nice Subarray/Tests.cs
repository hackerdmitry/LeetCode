using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2401._Longest_Nice_Subarray;

[TestFixture(TestName = "2401. Longest Nice Subarray")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,8,48,10]", 3)]
    [TestCase("[3,1,5,11,13]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestNiceSubarray(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
