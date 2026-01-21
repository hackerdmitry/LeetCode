using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._54._Spiral_Matrix;

[TestFixture(TestName = "54. Spiral Matrix")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2,3,4],[5,6,7,8],[9,10,11,12]]", "[1,2,3,4,8,12,11,10,9,5,6,7]")]
    [TestCase("[[1,2,3],[4,5,6],[7,8,9],[10,11,12]]", "[1,2,3,6,9,12,11,10,7,4,5,8]")]
    [TestCase("[[3],[2]]", "[3,2]")]
    [TestCase("[[1,2,3],[4,5,6],[7,8,9]]", "[1,2,3,6,9,8,7,4,5]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SpiralOrder(input.ParseIntArray2d());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
