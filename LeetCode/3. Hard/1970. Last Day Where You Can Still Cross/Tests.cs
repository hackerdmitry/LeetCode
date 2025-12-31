using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._1970._Last_Day_Where_You_Can_Still_Cross;

[TestFixture(TestName = "1970. Last Day Where You Can Still Cross")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, 2, "[[1,1],[2,1],[1,2],[2,2]]", 2)]
    [TestCase(2, 2, "[[1,1],[1,2],[2,1],[2,2]]", 1)]
    [TestCase(3, 3, "[[1,2],[2,1],[3,3],[2,2],[1,1],[1,3],[2,3],[3,2],[3,1]]", 3)]
    public void Test(int input1, int input2, string input3, int output)
    {
        var solution = new Solution();
        var actual = solution.LatestDayToCross(input1, input2, input3.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
