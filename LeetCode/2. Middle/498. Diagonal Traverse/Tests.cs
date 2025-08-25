using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._498._Diagonal_Traverse;

[TestFixture(TestName = "498. Diagonal Traverse")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2,3],[4,5,6],[7,8,9]]", "[1,2,4,7,5,3,6,8,9]")]
    [TestCase("[[1,2],[3,4]]", "[1,2,3,4]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.FindDiagonalOrder(input.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
