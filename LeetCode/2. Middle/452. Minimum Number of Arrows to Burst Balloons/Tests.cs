using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._452._Minimum_Number_of_Arrows_to_Burst_Balloons;

[TestFixture(TestName = "452. Minimum Number of Arrows to Burst Balloons")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[3,9],[7,12],[3,8],[6,8],[9,10],[2,9],[0,9],[3,9],[0,6],[2,8]]", 2)]
    [TestCase("[[10,16],[2,8],[1,6],[7,12]]", 2)]
    [TestCase("[[1,2],[3,4],[5,6],[7,8]]", 4)]
    [TestCase("[[1,2],[2,3],[3,4],[4,5]]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindMinArrowShots(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
