using NUnit.Framework;

namespace LeetCode._2._Middle._3163._String_Compression_III;

[TestFixture(TestName = "3163. String Compression III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcde", "1a1b1c1d1e")]
    [TestCase("aaaaaaaaaaaaaabb", "9a5a2b")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.CompressedString(input);
        Assert.AreEqual(output, actual);
    }
}
