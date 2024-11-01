using NUnit.Framework;

namespace LeetCode._1._Easy._1957._Delete_Characters_to_Make_Fancy_String;

[TestFixture(TestName = "1957. Delete Characters to Make Fancy String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("leeetcode", "leetcode")]
    [TestCase("aaabaaaa", "aabaa")]
    [TestCase("aab", "aab")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.MakeFancyString(input);
        Assert.AreEqual(output, actual);
    }
}
