using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._14._Longest_Common_Prefix;

[TestFixture(TestName = "14. Longest Common Prefix")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"flower\",\"flow\",\"flight\"]", "fl")]
    [TestCase("[\"dog\",\"racecar\",\"car\"]", "")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.LongestCommonPrefix(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}
