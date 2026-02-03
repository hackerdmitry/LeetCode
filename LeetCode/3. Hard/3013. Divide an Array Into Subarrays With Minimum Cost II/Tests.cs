using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._3013._Divide_an_Array_Into_Subarrays_With_Minimum_Cost_II;

[TestFixture(TestName = "3013. Divide an Array Into Subarrays With Minimum Cost II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,6,4,7,9,6,1]", 4, 4, 12)]
    [TestCase("[10,1,2,2,2,1]", 4, 3, 15)]
    [TestCase("[1,3,2,6,4,2]", 3, 3, 5)]
    [TestCase("[10,8,18,9]", 3, 1, 36)]
    public void Test(string input1, int input2, int input3, long output)
    {
        var solution = new Solution();
        var actual = solution.MinimumCost(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}
