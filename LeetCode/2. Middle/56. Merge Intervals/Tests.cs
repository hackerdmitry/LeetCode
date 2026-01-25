using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._56._Merge_Intervals;

[TestFixture(TestName = "56. Merge Intervals")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,3],[2,6],[8,10],[15,18]]", "[[1,6],[8,10],[15,18]]")]
    [TestCase("[[1,4],[4,5]]", "[[1,5]]")]
    [TestCase("[[4,7],[1,4]]", "[[1,7]]")]
    [TestCase("[[2,3],[4,5],[6,7],[8,9],[1,10]]", "[[1,10]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.Merge(input.ParseIntArray2d());
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
