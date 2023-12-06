using NUnit.Framework;

namespace LeetCode._1._Easy._1716._Calculate_Money_in_Leetcode_Bank;

[TestFixture(TestName = "1716. Calculate Money in Leetcode Bank")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, 10)]
    [TestCase(10, 37)]
    [TestCase(20, 96)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.TotalMoney(input);
        Assert.AreEqual(output, actual);
    }
}
