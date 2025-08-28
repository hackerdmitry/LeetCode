using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3446._Sort_Matrix_by_Diagonals;

[TestFixture(TestName = "3446. Sort Matrix by Diagonals")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,7,3],[9,8,2],[4,5,6]]", "[[8,2,3],[9,6,7],[4,5,1]]")]
    [TestCase("[[0,1],[1,2]]", "[[2,1],[1,0]]")]
    [TestCase("[[1]]", "[[1]]")]
    [TestCase("[[1,2,3],[4,5,6]]", "[[5,2,3],[4,1,6]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SortMatrix(input.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray2d(), actual);
    }
}
