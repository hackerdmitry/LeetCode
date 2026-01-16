using NUnit.Framework;

namespace LeetCode._2._Middle._72._Edit_Distance;

[TestFixture(TestName = "72. Edit Distance")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("exe", "ee", 1)]
    [TestCase("a", "aa", 1)]
    [TestCase("horse", "ros", 3)]
    [TestCase("intention", "execution", 5)]
    [TestCase("inte", "ex", 4)]
    [TestCase("inte", "exe", 3)]
    [TestCase("zoologicoarchaeologist", "zoogeologist", 10)]
    [TestCase("zo", "zoo", 1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MinDistance(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
