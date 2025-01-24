using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._802._Find_Eventual_Safe_States;

[TestFixture(TestName = "802. Find Eventual Safe States")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[],[0,2,3,4],[3],[4],[]]", "[0,1,2,3,4]")]
    [TestCase("[[1,2],[2,3],[5],[0],[5],[],[]]", "[2,4,5,6]")]
    [TestCase("[[1,2,3,4],[1,2],[3,4],[0,4],[]]", "[4]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.EventualSafeNodes(input.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
