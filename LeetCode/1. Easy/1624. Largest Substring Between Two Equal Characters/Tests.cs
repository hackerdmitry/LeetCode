using NUnit.Framework;

namespace LeetCode._1._Easy._1624._Largest_Substring_Between_Two_Equal_Characters;

[TestFixture(TestName = "1624. Largest Substring Between Two Equal Characters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aa", 0)]
    [TestCase("abca", 2)]
    [TestCase("cbzxy", -1)]
    [TestCase("mgntdygtxrvxjnwksqhxuxtrv", 18)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxLengthBetweenEqualCharacters(input);
        Assert.AreEqual(output, actual);
    }
}
