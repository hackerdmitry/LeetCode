using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3634._Minimum_Removals_to_Balance_Array;

[TestFixture(TestName = "3634. Minimum Removals to Balance Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,5]", 2, 1)]
    [TestCase("[1,6,2,9]", 3, 2)]
    [TestCase("[4,6]", 2, 0)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinRemoval(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
