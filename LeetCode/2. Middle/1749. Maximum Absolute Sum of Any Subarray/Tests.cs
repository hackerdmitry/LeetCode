using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1749._Maximum_Absolute_Sum_of_Any_Subarray;

[TestFixture(TestName = "1749. Maximum Absolute Sum of Any Subarray")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,-3,2,3,-4]", 5)]
    [TestCase("[2,-5,1,-4,3,-2]", 8)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxAbsoluteSum(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
