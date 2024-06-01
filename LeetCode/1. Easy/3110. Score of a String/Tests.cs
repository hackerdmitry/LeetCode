using NUnit.Framework;

namespace LeetCode._1._Easy._3110._Score_of_a_String;

[TestFixture(TestName = "3110. Score of a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("hello", 13)]
    [TestCase("zaz", 50)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.ScoreOfString(input);
        Assert.AreEqual(output, actual);
    }
}