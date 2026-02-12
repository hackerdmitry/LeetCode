using NUnit.Framework;

namespace LeetCode._2._Middle._3713._Longest_Balanced_Substring_I;

[TestFixture(TestName = "3713. Longest Balanced Substring I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("kooo", 3)]
    [TestCase("koookk", 6)]
    [TestCase("a", 1)]
    [TestCase("abbac", 4)]
    [TestCase("zzabccy", 4)]
    [TestCase("aba", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LongestBalanced(input);
        Assert.AreEqual(output, actual);
    }

    [Timeout(1000)]
    [Test]
    public void BigTest1()
    {
        var input = new string('a', 1000);
        var output = 1000;
        var solution = new Solution();

        var actual = solution.LongestBalanced(input);

        Assert.AreEqual(output, actual);
    }
}
