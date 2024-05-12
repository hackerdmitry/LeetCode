using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._15._3Sum;

[TestFixture(TestName = "15. 3Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[-1,0,1,2,-1,-4]", "[[-1,-1,2],[-1,0,1]]")]
    [TestCase("[0,1,1]", "[]")]
    [TestCase("[0,0,0]", "[[0,0,0]]")]
    [TestCase("[0,0,0,0,0,0,0]", "[[0,0,0]]")]
    public void Test(string input, string outputStr)
    {
        var solution = new Solution();
        var actual = solution.ThreeSum(input.ParseIntArray());
        var output = outputStr.ParseIntArray2d();
        output.WriteLine<int>("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(output, actual);
    }
}