using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._492._Construct_the_Rectangle;

[TestFixture(TestName = "492. Construct the Rectangle")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[2,2]")]
    [TestCase(37, "[37,1]")]
    [TestCase(122122, "[427,286]")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.ConstructRectangle(input);
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}