using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3362._Zero_Array_Transformation_III;

[TestFixture(TestName = "3362. Zero Array Transformation III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,0,2]", "[[0,2],[0,2],[1,1]]", 1)]
    [TestCase("[1,1,1,1]", "[[1,3],[0,2],[1,3],[1,2]]", 2)]
    [TestCase("[1,2,3,4]", "[[0,3]]", -1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxRemoval(input1.ParseIntArray(), input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
