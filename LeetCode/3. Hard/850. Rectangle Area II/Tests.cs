using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._850._Rectangle_Area_II;

[TestFixture(TestName = "850. Rectangle Area II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,0,2,2],[1,1,3,3],[2,0,4,2]]", 10)]
    [TestCase("[[0,0,2,2],[1,0,2,3],[1,0,3,1],[4,0,6,1]]", 8)]
    [TestCase("[[0,0,2,2]]", 4)]
    [TestCase("[[0,0,2,2],[1,0,2,3],[1,0,3,1]]", 6)]
    [TestCase("[[0,0,1000000000,1000000000]]", 49)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.RectangleArea(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
