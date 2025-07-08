using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1353._Maximum_Number_of_Events_That_Can_Be_Attended;

[TestFixture(TestName = "1353. Maximum Number of Events That Can Be Attended")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,10],[2,2],[2,2],[2,2],[2,2]]", 2)]
    [TestCase("[[1,4],[4,4],[2,2],[3,4],[1,1]]", 4)]
    [TestCase("[[1,5],[1,5],[1,5],[2,3],[2,3]]", 5)]
    [TestCase("[[1,2],[1,2],[3,3],[1,5],[1,5]]", 5)]
    [TestCase("[[1,2],[2,3],[3,4],[1,2]]", 4)]
    [TestCase("[[1,2],[2,3],[3,4]]", 3)]
    [TestCase("[[1,2],[1,2],[3,4]]", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxEvents(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
