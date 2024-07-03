using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._974._Subarray_Sums_Divisible_by_K;

[TestFixture(TestName = "974. Subarray Sums Divisible by K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,5,0,-2,-3,1]", 5, 7)]
    [TestCase("[5]", 9, 0)]
    [TestCase("[7,4,-10]", 5, 1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.SubarraysDivByK(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
