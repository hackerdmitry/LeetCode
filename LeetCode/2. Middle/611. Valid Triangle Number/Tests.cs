using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._611._Valid_Triangle_Number;

[TestFixture(TestName = "611. Valid Triangle Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,2,3,4]", 3)]
    [TestCase("[4,2,3,4]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.TriangleNumber(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
