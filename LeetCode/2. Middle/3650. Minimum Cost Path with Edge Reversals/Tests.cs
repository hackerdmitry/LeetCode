using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3650._Minimum_Cost_Path_with_Edge_Reversals;

[TestFixture(TestName = "3650. Minimum Cost Path with Edge Reversals")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[0,1,3],[3,1,1],[2,3,4],[0,2,2]]", 5)]
    [TestCase(4, "[[0,2,1],[2,1,1],[1,3,1],[2,3,3]]", 3)]
    public void Test(int input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinCost(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
