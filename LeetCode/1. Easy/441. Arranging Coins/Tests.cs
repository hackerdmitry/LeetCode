using NUnit.Framework;

namespace LeetCode._1._Easy._441._Arranging_Coins;

[TestFixture(TestName = "441. Arranging Coins")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1804289383, 60070)]
    [TestCase(5, 2)]
    [TestCase(8, 3)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.ArrangeCoins(input);
        Assert.AreEqual(output, actual);
    }
}
