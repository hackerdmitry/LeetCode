using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._368._Largest_Divisible_Subset;

[TestFixture(TestName = "368. Largest Divisible Subset")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3]", "[1,2]")]
    [TestCase("[1,2,4,8]", "[1,2,4,8]")]
    [TestCase("[1,2,4,6,18]", "[1,2,6,18]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.LargestDivisibleSubset(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
