using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._73._Set_Matrix_Zeroes;

[TestFixture(TestName = "73. Set Matrix Zeroes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2,3,4],[5,0,7,8],[0,10,11,12],[13,14,15,0]]", "[[0,0,3,0],[0,0,0,0],[0,0,0,0],[0,0,0,0]]")]
    [TestCase("[[1,1,1],[1,0,1],[1,1,1]]", "[[1,0,1],[0,0,0],[1,0,1]]")]
    [TestCase("[[0,1,2,0],[3,4,5,2],[1,3,1,5]]", "[[0,0,0,0],[0,4,5,0],[0,3,1,0]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = input.ParseIntArray2d();
        actual.WriteLine("matrix");
        solution.SetZeroes(actual);
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}