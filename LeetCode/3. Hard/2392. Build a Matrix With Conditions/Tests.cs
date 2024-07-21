using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._2392._Build_a_Matrix_With_Conditions;

[TestFixture(TestName = "2392. Build a Matrix With Conditions")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(7, "[[2,4],[1,7],[1,4],[7,3],[3,4],[5,7],[3,4],[1,3],[5,7],[6,5],[7,3],[6,7],[2,4],[1,4],[2,7],[3,4],[2,7],[6,5],[2,7],[7,3]]", "[[1,6],[1,6],[1,7],[4,7],[1,6],[7,6],[1,5],[5,2],[1,2],[3,2],[1,4]]", "[[0,0,0,0,0,0,6],[0,0,0,5,0,0,0],[0,0,0,0,2,0,0],[0,1,0,0,0,0,0],[0,0,0,0,0,7,0],[3,0,0,0,0,0,0],[0,0,4,0,0,0,0]]")]
    [TestCase(3, "[[1,2],[3,2]]", "[[2,1],[3,2]]", "[[3,0,0],[0,0,1],[0,2,0]]")]
    [TestCase(8, "[[1,2],[7,3],[4,3],[5,8],[7,8],[8,2],[5,8],[3,2],[1,3],[7,6],[4,3],[7,4],[4,8],[7,3],[7,5]]", "[[5,7],[2,7],[4,3],[6,7],[4,3],[2,3],[6,2]]", "[[0,0,0,0,0,0,7,0],[0,6,0,0,0,0,0,0],[0,0,5,0,0,0,0,0],[0,0,0,4,0,0,0,0],[8,0,0,0,0,0,0,0],[0,0,0,0,0,0,0,1],[0,0,0,0,0,3,0,0],[0,0,0,0,2,0,0,0]]")]
    [TestCase(3, "[[1,2],[2,3],[3,1],[2,3]]", "[[2,1]]", "[]")]
    public void Test(int input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.BuildMatrix(input1, input2.ParseIntArray2d(), input3.ParseIntArray2d());
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
