using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3809._Best_Reachable_Tower;

[TestFixture(TestName = "3809. Best Reachable Tower")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2,5],[2,1,7],[3,1,9]]", "[1,1]", 2, "[3,1]")]
    [TestCase("[[1,3,4],[2,2,4],[4,4,7]]", "[0,0]", 5, "[1,3]")]
    [TestCase("[[5,6,8],[0,3,5]]", "[1,2]", 1, "[-1,-1]")]
    [TestCase("[[3,2,92065],[5,2,50137]]", "[51252,81840]", 32957, "[-1,-1]")]
    public void Test(string input1, string input2, int input3, string output)
    {
        var solution = new Solution();
        var actual = solution.BestTower(input1.ParseIntArray2d(), input2.ParseIntArray(), input3);
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}