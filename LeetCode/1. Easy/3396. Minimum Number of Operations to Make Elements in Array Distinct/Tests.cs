using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3396._Minimum_Number_of_Operations_to_Make_Elements_in_Array_Distinct;

[TestFixture(TestName = "3396. Minimum Number of Operations to Make Elements in Array Distinct")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,2,3,3,5,7]", 2)]
    [TestCase("[4,5,6,4,4]", 2)]
    [TestCase("[6,7,8,9]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumOperations(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
