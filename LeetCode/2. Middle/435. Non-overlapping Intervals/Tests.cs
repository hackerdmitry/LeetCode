using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._435._Non_overlapping_Intervals;

[TestFixture(TestName = "435. Non-overlapping Intervals")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2],[2,3],[3,4],[1,3]]", 1)]
    [TestCase("[[1,2],[1,2],[1,2]]", 2)]
    [TestCase("[[1,2],[2,3]]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.EraseOverlapIntervals(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
