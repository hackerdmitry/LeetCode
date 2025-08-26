using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3000._Maximum_Area_of_Longest_Diagonal_Rectangle;

[TestFixture(TestName = "3000. Maximum Area of Longest Diagonal Rectangle")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[9,3],[8,6]]", 48)]
    [TestCase("[[3,4],[4,3]]", 12)]
    [TestCase("[[6,5],[8,6],[2,10],[8,1],[9,2],[3,5],[3,5]]", 20)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.AreaOfMaxDiagonal(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}