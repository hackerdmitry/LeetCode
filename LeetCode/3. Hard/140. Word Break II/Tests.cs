using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._140._Word_Break_II;

[TestFixture(TestName = "140. Word Break II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("catsanddog", "[\"cat\",\"cats\",\"and\",\"sand\",\"dog\"]", "[\"cats and dog\",\"cat sand dog\"]")]
    [TestCase("pineapplepenapple", "[\"apple\",\"pen\",\"applepen\",\"pine\",\"pineapple\"]", "[\"pine apple pen apple\",\"pineapple pen apple\",\"pine applepen apple\"]")]
    [TestCase("catsandog", "[\"cats\",\"dog\",\"sand\",\"and\",\"cat\"]", "[]")]
    [TestCase("a", "[\"b\"]", "[]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.WordBreak(input1, input2.ParseStringArray()).OrderBy(x => x).ToArray();
        var expected = output.ParseStringArray().OrderBy(x => x).ToArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}