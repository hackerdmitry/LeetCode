using NUnit.Framework;

namespace LeetCode._2._Middle._6._Zigzag_Conversion;

[TestFixture(TestName = "6. Zigzag Conversion")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
    [TestCase("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
    [TestCase("A", 1, "A")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.Convert(input1, input2);
        Assert.AreEqual(output, actual);
    }
}