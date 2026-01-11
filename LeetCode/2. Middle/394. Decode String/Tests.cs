using NUnit.Framework;

namespace LeetCode._2._Middle._394._Decode_String;

[TestFixture(TestName = "394. Decode String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("3[a]", "aaa")]
    [TestCase("sd2[f2[e]g]i", "sdfeegfeegi")]
    [TestCase("3[a]2[bc]", "aaabcbc")]
    [TestCase("3[a2[c]]", "accaccacc")]
    [TestCase("2[a2[b2[c]]]", "abccbccabccbcc")]
    [TestCase("2[abc]3[cd]ef", "abcabccdcdcdef")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.DecodeString(input);
        Assert.AreEqual(output, actual);
    }
}
