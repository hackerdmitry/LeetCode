using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._945._Minimum_Increment_to_Make_Array_Unique;

[TestFixture(TestName = "945. Minimum Increment to Make Array Unique")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,2]", 1)]
    [TestCase("[1,2,2,2]", 3)]
    [TestCase("[3,2,1,2,1,7]", 6)]
    [TestCase("[0,2,0]", 1)]
    [TestCase("[0,2,0,0]", 4)]
    [TestCase("[7,2,7,2,1,4,3,1,4,8]", 16)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinIncrementForUnique(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
