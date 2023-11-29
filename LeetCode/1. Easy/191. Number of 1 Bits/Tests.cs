using System.Globalization;
using NUnit.Framework;

namespace LeetCode._1._Easy._191._Number_of_1_Bits;

[TestFixture(TestName = "191. Number of 1 Bits")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(0b00000000000000000000000000001011U, 3)]
    [TestCase(0b00000000000000000000000010000000U, 1)]
    [TestCase(0b11111111111111111111111111111101U, 31)]
    public void Test(uint input, int output)
    {
        var solution = new Solution();
        var actual = solution.HammingWeight(input);
        Assert.AreEqual(output, actual);
    }
}
