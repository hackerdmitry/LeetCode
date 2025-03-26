using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2033._Minimum_Operations_to_Make_a_Uni_Value_Grid;

[TestFixture(TestName = "2033. Minimum Operations to Make a Uni-Value Grid")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[2,4],[6,8]]", 2, 4)]
    [TestCase("[[1,5],[2,3]]", 1, 5)]
    [TestCase("[[1,2],[3,4]]", 2, -1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input1.ParseIntArray2d(), input2);
        Assert.AreEqual(output, actual);
    }
}
