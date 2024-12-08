using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2054._Two_Best_Non_Overlapping_Events;

[TestFixture(TestName = "2054. Two Best Non-Overlapping Events")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,3,2],[4,5,2],[2,4,3]]", 4)]
    [TestCase("[[66,97,90],[98,98,68],[38,49,63],[91,100,42],[92,100,22],[1,77,50],[64,72,97]]", 165)]
    [TestCase("[[1,3,2],[4,5,2],[1,5,5]]", 5)]
    [TestCase("[[1,5,3],[1,5,1],[6,6,5]]", 8)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxTwoEvents(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}