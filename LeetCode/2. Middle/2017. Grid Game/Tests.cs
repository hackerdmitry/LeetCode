using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2017._Grid_Game;

[TestFixture(TestName = "2017. Grid Game")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[2,5,4],[1,5,1]]", 4)]
    [TestCase("[[3,3,1],[8,5,2]]", 4)]
    [TestCase("[[1,3,1,15],[1,3,3,1]]", 7)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.GridGame(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
