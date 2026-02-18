using NUnit.Framework;

namespace LeetCode._1._Easy._693._Binary_Number_with_Alternating_Bits;

[TestFixture(TestName = "693. Binary Number with Alternating Bits")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, true)]
    [TestCase(7, false)]
    [TestCase(11, false)]
    public void Test(int input, bool output)
    {
        var solution = new Solution();
        var actual = solution.HasAlternatingBits(input);
        Assert.AreEqual(output, actual);
    }
}
