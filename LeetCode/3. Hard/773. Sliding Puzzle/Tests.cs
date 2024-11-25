using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._773._Sliding_Puzzle;

[TestFixture(TestName = "773. Sliding Puzzle")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2,3],[4,0,5]]", 1)]
    [TestCase("[[1,2,3],[5,4,0]]", -1)]
    [TestCase("[[4,1,2],[5,0,3]]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SlidingPuzzle(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}