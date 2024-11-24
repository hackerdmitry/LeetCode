using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1975._Maximum_Matrix_Sum;

[TestFixture(TestName = "1975. Maximum Matrix Sum")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[2,9,3],[5,4,-4],[1,7,1]]", 34)]
    [TestCase("[[1,-1],[-1,1]]", 4)]
    [TestCase("[[1,-1],[1,1]]", 2)]
    [TestCase("[[1,2,3],[-1,-2,-3],[1,2,3]]", 16)]
    public void Test(string input, long output)
    {
        var solution = new Solution();
        var actual = solution.MaxMatrixSum(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}