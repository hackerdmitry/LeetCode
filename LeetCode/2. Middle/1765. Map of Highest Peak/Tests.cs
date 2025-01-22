using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1765._Map_of_Highest_Peak;

[TestFixture(TestName = "1765. Map of Highest Peak")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1],[0,0]]", "[[1,0],[2,1]]")]
    [TestCase("[[0,0,1],[1,0,0],[0,0,0]]", "[[1,1,0],[0,1,1],[1,2,2]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.HighestPeak(input.ParseIntArray2d());
        var expected = output.ParseIntArray2d();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
