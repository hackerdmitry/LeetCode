using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._289._Game_of_Life;

[TestFixture(TestName = "289. Game of Life")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1,0],[0,0,1],[1,1,1],[0,0,0]]", "[[0,0,0],[1,0,1],[0,1,1],[0,1,0]]")]
    [TestCase("[[1,1],[1,0]]", "[[1,1],[1,1]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = input.ParseIntArray2d();
        solution.GameOfLife(actual);
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}