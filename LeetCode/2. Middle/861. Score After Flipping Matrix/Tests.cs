using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._861._Score_After_Flipping_Matrix;

[TestFixture(TestName = "861. Score After Flipping Matrix")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,0,1,1],[1,0,1,0],[1,1,0,0]]", 39)]
    [TestCase("[[0]]", 1)]
    [TestCase("[[0,1],[1,1]]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MatrixScore(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}