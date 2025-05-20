using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3355._Zero_Array_Transformation_I;

[TestFixture(TestName = "3355. Zero Array Transformation I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,0,1]", "[[0,2]]", true)]
    [TestCase("[4,3,2,1]", "[[1,3],[0,2]]", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsZeroArray(input1.ParseIntArray(), input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
