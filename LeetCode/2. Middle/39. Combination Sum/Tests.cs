using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._39._Combination_Sum;

[TestFixture(TestName = "39. Combination Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,5]", 8, "[[2,2,2,2],[2,3,3],[3,5]]")]
    [TestCase("[2,3,6,7]", 7, "[[2,2,3],[7]]")]
    [TestCase("[2]", 1, "[]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.CombinationSum(input1.ParseIntArray(), input2);
        var expected = output.ParseIntArray2d();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}