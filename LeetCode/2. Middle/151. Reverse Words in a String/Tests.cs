using NUnit.Framework;

namespace LeetCode._2._Middle._151._Reverse_Words_in_a_String;

[TestFixture(TestName = "151. Reverse Words in a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("the sky is blue", "blue is sky the")]
    [TestCase("  hello world  ", "world hello")]
    [TestCase("a good   example", "example good a")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ReverseWords(input);
        Assert.AreEqual(output, actual);
    }
}
