using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._48._Rotate_Image;

[TestFixture(TestName = "48. Rotate Image")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2,3],[4,5,6],[7,8,9]]", "[[7,4,1],[8,5,2],[9,6,3]]")]
    [TestCase("[[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]", "[[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = input.ParseIntArray2d();
        solution.Rotate(actual);
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
