using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._885._Spiral_Matrix_III;

[TestFixture(TestName = "885. Spiral Matrix III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, 4, 0, 0, "[[0,0],[0,1],[0,2],[0,3]]")]
    [TestCase(5, 6, 1, 4, "[[1,4],[1,5],[2,5],[2,4],[2,3],[1,3],[0,3],[0,4],[0,5],[3,5],[3,4],[3,3],[3,2],[2,2],[1,2],[0,2],[4,5],[4,4],[4,3],[4,2],[4,1],[3,1],[2,1],[1,1],[0,1],[4,0],[3,0],[2,0],[1,0],[0,0]]")]
    public void Test(int input1, int input2, int input3, int input4, string output)
    {
        var solution = new Solution();
        var actual = solution.SpiralMatrixIII(input1, input2, input3, input4);
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
