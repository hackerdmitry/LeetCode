using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._841._Keys_and_Rooms;

[TestFixture(TestName = "841. Keys and Rooms")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1],[2],[3],[]]", true)]
    [TestCase("[[1,3],[3,0,1],[2],[0]]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanVisitAllRooms(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
