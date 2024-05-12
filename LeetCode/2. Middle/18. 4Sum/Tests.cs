using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._18._4Sum;

[TestFixture(TestName = "18. 4Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,0,-1,0,-2,2]", 0, "[[-2,-1,1,2],[-2,0,0,2],[-1,0,0,1]]")]
    [TestCase("[2,2,2,2,2]", 8, "[[2,2,2,2]]")]
    [TestCase("[1000000000,1000000000,1000000000,1000000000]", -294967296, "[]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.FourSum(input1.ParseIntArray(), input2);
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}