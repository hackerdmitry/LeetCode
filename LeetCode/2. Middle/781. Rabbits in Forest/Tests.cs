using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._781._Rabbits_in_Forest;

[TestFixture(TestName = "781. Rabbits in Forest")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,1,2]", 5)]
    [TestCase("[0]", 1)]
    [TestCase("[10,10,10]", 11)]
    [TestCase("[2,2,2,2]", 6)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumRabbits(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
