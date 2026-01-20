using NUnit.Framework;

namespace LeetCode._1._Easy._58._Length_of_Last_Word;

[TestFixture(TestName = "58. Length of Last Word")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("Hello World", 5)]
    [TestCase("   fly me   to   the moon  ", 4)]
    [TestCase("luffy is still joyboy", 6)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.LengthOfLastWord(input);
        Assert.AreEqual(output, actual);
    }
}
