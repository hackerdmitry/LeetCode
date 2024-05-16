using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._216._Combination_Sum_III;

[TestFixture(TestName = "216. Combination Sum III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3, 7, "[[1,2,4]]")]
    [TestCase(3, 9, "[[1,2,6],[1,3,5],[2,3,4]]")]
    [TestCase(4, 1, "[]")]
    public void Test(int input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.CombinationSum3(input1, input2);
        Assert.AreEqual(output.ParseIntArray2d(), actual);
    }
}