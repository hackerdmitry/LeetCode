using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3191._Minimum_Operations_to_Make_Binary_Array_Elements_Equal_to_One_I;

[TestFixture(TestName = "3191. Minimum Operations to Make Binary Array Elements Equal to One I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,1,1,1,0,0]", 3)]
    [TestCase("[0,1,1,1]", -1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
