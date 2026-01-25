using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3818._Minimum_Prefix_Removal_to_Make_Array_Strictly_Increasing;

[TestFixture(TestName = "3818. Minimum Prefix Removal to Make Array Strictly Increasing")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,-1,2,3,3,4,5]", 4)]
    [TestCase("[4,3,-2,-5]", 3)]
    [TestCase("[1,2,3,4]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumPrefixLength(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
