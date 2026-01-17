using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3047._Find_the_Largest_Area_of_Square_Inside_Two_Rectangles;

[TestFixture(TestName = "3047. Find the Largest Area of Square Inside Two Rectangles")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[2,2],[1,3]]", "[[3,4],[5,5]]", 1)]
    [TestCase("[[1,1],[2,2],[3,1]]", "[[3,3],[4,4],[6,6]]", 1)]
    [TestCase("[[1,1],[1,3],[1,5]]", "[[5,5],[5,7],[5,9]]", 4)]
    [TestCase("[[1,1],[2,2],[1,2]]", "[[3,3],[4,4],[3,4]]", 1)]
    [TestCase("[[1,1],[3,3],[3,1]]", "[[2,2],[4,4],[4,2]]", 0)]
    public void Test(string input1, string input2, long output)
    {
        var solution = new Solution();
        var actual = solution.LargestSquareArea(input1.ParseIntArray2d(), input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
