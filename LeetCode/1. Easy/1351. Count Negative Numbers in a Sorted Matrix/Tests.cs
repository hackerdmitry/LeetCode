using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1351._Count_Negative_Numbers_in_a_Sorted_Matrix;

[TestFixture(TestName = "1351. Count Negative Numbers in a Sorted Matrix")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[5,1,0],[-5,-5,-5]]", 3)]
    [TestCase("[[4,3,2,-1],[3,2,1,-1],[1,1,-1,-2],[-1,-1,-2,-3]]", 8)]
    [TestCase("[[3,2],[1,0]]", 0)]
    [TestCase("[[3,2],[1,0],[0,-1]]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountNegatives(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
