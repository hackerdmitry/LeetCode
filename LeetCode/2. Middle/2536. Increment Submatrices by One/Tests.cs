using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2536._Increment_Submatrices_by_One;

[TestFixture(TestName = "2536. Increment Submatrices by One")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, "[[0,0,1,1]]", "[[1,1],[1,1]]")]
    [TestCase(2, "[[0,1,0,1]]", "[[0,1],[0,0]]")]
    [TestCase(3, "[[1,1,2,2],[0,0,1,1]]", "[[1,1,0],[1,2,1],[0,1,1]]")]
    [TestCase(3, "[[0,0,1,1],[1,1,1,1],[1,2,1,2],[2,1,2,1]]", "[[1,1,0],[1,2,1],[0,1,0]]")]
    public void Test(int input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.RangeAddQueries(input1, input2.ParseIntArray2d());
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
