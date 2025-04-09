using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3375._Minimum_Operations_to_Make_Array_Values_Equal_to_K;

[TestFixture(TestName = "3375. Minimum Operations to Make Array Values Equal to K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,2,5,4,5]", 2, 2)]
    [TestCase("[2,1,2]", 2, -1)]
    [TestCase("[9,7,5,3]", 1, 4)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
