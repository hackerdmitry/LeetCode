using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2658._Maximum_Number_of_Fish_in_a_Grid;

[TestFixture(TestName = "2658. Maximum Number of Fish in a Grid")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,2,1,0],[4,0,0,3],[1,0,0,4],[0,3,2,0]]", 7)]
    [TestCase("[[1,0,0,0],[0,0,0,0],[0,0,0,0],[0,0,0,1]]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindMaxFish(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
