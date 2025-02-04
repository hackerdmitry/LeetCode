using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1800._Maximum_Ascending_Subarray_Sum;

[TestFixture(TestName = "1800. Maximum Ascending Subarray Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[10,20,30,5,10,50]", 65)]
    [TestCase("[10,20,30,40,50]", 150)]
    [TestCase("[12,17,15,13,10,11,12]", 33)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxAscendingSum(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
