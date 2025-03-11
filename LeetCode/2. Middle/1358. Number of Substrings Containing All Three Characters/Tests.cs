using NUnit.Framework;

namespace LeetCode._2._Middle._1358._Number_of_Substrings_Containing_All_Three_Characters;

[TestFixture(TestName = "1358. Number of Substrings Containing All Three Characters")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("acbbcac", 11)]
    [TestCase("aaacb", 3)]
    [TestCase("abcabc", 10)]
    [TestCase("abc", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumberOfSubstrings(input);
        Assert.AreEqual(output, actual);
    }
}
