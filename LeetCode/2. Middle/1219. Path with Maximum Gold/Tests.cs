using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1219._Path_with_Maximum_Gold;

[TestFixture(TestName = "1219. Path with Maximum Gold")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,6,0],[5,8,7],[0,9,0]]", 24)]
    [TestCase("[[1,0,7],[2,0,6],[3,4,5],[0,3,0],[9,0,20]]", 28)]
    [TestCase("[[1,0,7,0,0,0],[2,0,6,0,1,0],[3,5,6,7,4,2],[4,3,1,0,2,0],[3,0,5,0,20,0]]", 60)]
    [TestCase("[[0,0,34,0,5,0,7,0,0,0],[0,0,0,0,21,0,0,0,0,0],[0,18,0,0,8,0,0,0,4,0],[0,0,0,0,0,0,0,0,0,0],[15,0,0,0,0,22,0,0,0,21],[0,0,0,0,0,0,0,0,0,0],[0,7,0,0,0,0,0,0,38,0]]", 38)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.GetMaximumGold(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}