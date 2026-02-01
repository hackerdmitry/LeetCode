using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3010._Divide_an_Array_Into_Subarrays_With_Minimum_Cost_I;

[TestFixture(TestName = "3010. Divide an Array Into Subarrays With Minimum Cost I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,12]", 6)]
    [TestCase("[5,4,3]", 12)]
    [TestCase("[10,3,1,1]", 12)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumCost(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
