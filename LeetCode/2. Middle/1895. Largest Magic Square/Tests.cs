using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1895._Largest_Magic_Square;

[TestFixture(TestName = "1895. Largest Magic Square")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[7,1,4,5,6],[2,5,1,6,4],[1,5,4,3,2],[1,2,7,3,4]]", 3)]
    [TestCase("[[5,1,3,1],[9,3,3,1],[1,3,3,8]]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LargestMagicSquare(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
