using NUnit.Framework;

namespace LeetCode._2._Middle._8._String_to_Integer__atoi_;

[TestFixture(TestName = "8. String to Integer (atoi)")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("42", 42)]
    [TestCase(" -042", -42)]
    [TestCase("1337c0d3", 1337)]
    [TestCase("0-1", 0)]
    [TestCase("words and 987", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MyAtoi(input);
        Assert.AreEqual(output, actual);
    }
}