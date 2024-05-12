using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2373._Largest_Local_Values_in_a_Matrix;

[TestFixture(TestName = "2373. Largest Local Values in a Matrix")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[9,9,8,1],[5,6,2,6],[8,2,6,4],[6,2,2,2]]", "[[9,9],[8,6]]")]
    [TestCase("[[1,1,1,1,1],[1,1,1,1,1],[1,1,2,1,1],[1,1,1,1,1],[1,1,1,1,1]]", "[[2,2,2],[2,2,2],[2,2,2]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.LargestLocal(input.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray2d(), actual);
    }
}