using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._3108._Minimum_Cost_Walk_in_Weighted_Graph;

[TestFixture(TestName = "3108. Minimum Cost Walk in Weighted Graph")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, "[[0,1,7],[1,3,7],[1,2,1]]", "[[0,3],[3,4]]", "[1,-1]")]
    [TestCase(3, "[[0,2,7],[0,1,15],[1,2,6],[1,2,1]]", "[[1,2]]", "[0]")]
    public void Test(int input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.MinimumCost(input1, input2.ParseIntArray2d(), input3.ParseIntArray2d());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
