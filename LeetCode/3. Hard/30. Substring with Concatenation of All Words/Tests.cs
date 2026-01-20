using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._30._Substring_with_Concatenation_of_All_Words;

[TestFixture(TestName = "30. Substring with Concatenation of All Words")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("ababababab", "[\"ababa\",\"babab\"]", "[0]")]
    [TestCase("wordgoodgoodgoodbestword", "[\"word\",\"good\",\"best\",\"good\"]", "[8]")]
    [TestCase("barfoothefoobarman", "[\"foo\",\"bar\"]", "[0,9]")]
    [TestCase("wordgoodgoodgoodbestword", "[\"word\",\"good\",\"best\",\"word\"]", "[]")]
    [TestCase("barfoofoobarthefoobarman", "[\"bar\",\"foo\",\"the\"]", "[6,9,12]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.FindSubstring(input1, input2.ParseStringArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
