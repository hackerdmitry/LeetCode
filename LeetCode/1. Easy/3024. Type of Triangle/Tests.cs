using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3024._Type_of_Triangle;

[TestFixture(TestName = "3024. Type of Triangle")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,3,3]", "equilateral")]
    [TestCase("[3,4,5]", "scalene")]
    [TestCase("[9,4,9]", "isosceles")]
    [TestCase("[8,4,2]", "none")]
    [TestCase("[2,3,4]", "scalene")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.TriangleType(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
