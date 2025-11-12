using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2654._Minimum_Number_of_Operations_to_Make_All_Array_Elements_Equal_to_1;

[TestFixture(TestName = "2654. Minimum Number of Operations to Make All Array Elements Equal to 1")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1]", 0)]
    [TestCase("[6,10,15]", 4)]
    [TestCase("[2,6,3,4]", 4)]
    [TestCase("[2,10,6,14]", -1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
