using NUnit.Framework;

namespace LeetCode._2._Middle._91._Decode_Ways;

[TestFixture(TestName = "91. Decode Ways")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("12", 2)]
    [TestCase("226", 3)]
    [TestCase("06", 0)]
    [TestCase("11106", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumDecodings(input);
        Assert.AreEqual(output, actual);
    }
}
