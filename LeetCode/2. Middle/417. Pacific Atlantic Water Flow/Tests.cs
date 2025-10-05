using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._417._Pacific_Atlantic_Water_Flow;

[TestFixture(TestName = "417. Pacific Atlantic Water Flow")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]", "[[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]")]
    [TestCase("[[1]]", "[[0,0]]")]
    [TestCase("[[1,1],[1,1],[1,1]]", "[[0,0],[0,1],[1,0],[1,1],[2,0],[2,1]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.PacificAtlantic(input.ParseIntArray2d());
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
