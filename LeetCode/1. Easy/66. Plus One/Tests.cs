using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._66._Plus_One;

[TestFixture(TestName = "66. Plus One")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3]", "[1,2,4]")]
    [TestCase("[4,3,2,1]", "[4,3,2,2]")]
    [TestCase("[1,9]", "[2,0]")]
    [TestCase("[1,6,9,9]", "[1,7,0,0]")]
    [TestCase("[9]", "[1,0]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.PlusOne(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
