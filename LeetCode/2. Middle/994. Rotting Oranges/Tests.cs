using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._994._Rotting_Oranges;

[TestFixture(TestName = "994. Rotting Oranges")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[2,1,1],[1,1,0],[0,1,1]]", 4)]
    [TestCase("[[2,1,1],[0,1,1],[1,0,1]]", -1)]
    [TestCase("[[0,2]]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.OrangesRotting(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
