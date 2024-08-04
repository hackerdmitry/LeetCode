using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1508._Range_Sum_of_Sorted_Subarray_Sums;

[TestFixture(TestName = "1508. Range Sum of Sorted Subarray Sums")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4]", 4, 1, 5, 13)]
    [TestCase("[1,2,3,4]", 4, 3, 4, 6)]
    [TestCase("[1,2,3,4]", 4, 1, 10, 50)]
    public void Test(string input1, int input2, int input3, int input4, int output)
    {
        var solution = new Solution();
        var actual = solution.RangeSum(input1.ParseIntArray(), input2, input3, input4);
        Assert.AreEqual(output, actual);
    }
}