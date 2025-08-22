using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3195._Find_the_Minimum_Area_to_Cover_All_Ones_I;

[TestFixture(TestName = "3195. Find the Minimum Area to Cover All Ones I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1,0],[1,0,1]]", 6)]
    [TestCase("[[1,0],[0,0]]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumArea(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
