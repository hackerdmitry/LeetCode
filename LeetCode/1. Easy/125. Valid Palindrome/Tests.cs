using NUnit.Framework;

namespace LeetCode._1._Easy._125._Valid_Palindrome;

[TestFixture(TestName = "125. Valid Palindrome")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("A man, a plan, a canal: Panama", true)]
    [TestCase("race a car", false)]
    [TestCase(" ", true)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsPalindrome(input);
        Assert.AreEqual(output, actual);
    }
}
