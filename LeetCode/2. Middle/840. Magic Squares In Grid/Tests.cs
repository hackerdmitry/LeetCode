using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._840._Magic_Squares_In_Grid;

[TestFixture(TestName = "840. Magic Squares In Grid")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[4,3,8,4],[9,5,1,9],[2,7,6,2]]", 1)]
    [TestCase("[[8]]", 0)]
    [TestCase("[[8,0,7,4,3,2],[1,10,4,4,3,8],[8,5,2,9,5,1],[6,0,9,2,7,6],[9,0,6,9,5,1],[4,2,1,4,3,8]]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumMagicSquaresInside(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
