using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._407._Trapping_Rain_Water_II;

[TestFixture(TestName = "407. Trapping Rain Water II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,4,3,1,3,2],[3,2,1,3,2,4],[2,3,3,2,3,1]]", 4)]
    [TestCase("[[3,3,3,3,3],[3,2,2,2,3],[3,2,1,2,3],[3,2,2,2,3],[3,3,3,3,3]]", 10)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.TrapRainWater(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
