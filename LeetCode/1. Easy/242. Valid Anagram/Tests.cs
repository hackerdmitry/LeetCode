using NUnit.Framework;

namespace LeetCode._1._Easy._242._Valid_Anagram;

[TestFixture(TestName = "242. Valid Anagram")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("anagram", "nagaram", true)]
    [TestCase("rat", "car", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsAnagram(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
