using NUnit.Framework;

namespace LeetCode._1._Easy._190._Reverse_Bits;

[TestFixture(TestName = "190. Reverse Bits")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(43261596, 964176192)]
    [TestCase(2147483644, 1073741822)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.ReverseBits(input);
        Assert.AreEqual(output, actual);
    }
}
