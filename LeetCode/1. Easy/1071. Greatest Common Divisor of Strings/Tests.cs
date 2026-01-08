using NUnit.Framework;

namespace LeetCode._1._Easy._1071._Greatest_Common_Divisor_of_Strings;

[TestFixture(TestName = "1071. Greatest Common Divisor of Strings")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("ABCABC", "ABC", "ABC")]
    [TestCase("ABABAB", "ABAB", "AB")]
    [TestCase("LEET", "CODE", "")]
    [TestCase("AAAAAB", "AAA", "")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.GcdOfStrings(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
