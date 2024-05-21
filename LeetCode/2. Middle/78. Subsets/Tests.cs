using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._78._Subsets;

[TestFixture(TestName = "78. Subsets")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3]", "[[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]")]
    [TestCase("[0]", "[[],[0]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.Subsets(input.ParseIntArray());
        var expected = output.ParseIntArray2d();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}