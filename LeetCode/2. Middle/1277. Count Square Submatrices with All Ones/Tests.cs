using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1277._Count_Square_Submatrices_with_All_Ones;

[TestFixture(TestName = "1277. Count Square Submatrices with All Ones")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1,1,1],[1,1,1,1],[0,1,1,1]]", 15)]
    [TestCase("[[1,0,1],[1,1,0],[1,1,0]]", 7)]
    [TestCase("[[1,0,0],[1,1,1]]", 4)]
    [TestCase("[[1,0,1,0,1],[1,0,0,1,1],[0,1,0,1,1],[1,0,0,1,1]]", 14)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountSquares(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
