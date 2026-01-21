using NUnit.Framework;

namespace LeetCode._3._Hard._76._Minimum_Window_Substring;

[TestFixture(TestName = "76. Minimum Window Substring")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("a", "b", "")]
    [TestCase("ADOBECODEBANC", "ABC", "BANC")]
    [TestCase("a", "a", "a")]
    [TestCase("a", "aa", "")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.MinWindow(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
