using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1475._Final_Prices_With_a_Special_Discount_in_a_Shop;

[TestFixture(TestName = "1475. Final Prices With a Special Discount in a Shop")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[8,4,6,2,3]", "[4,2,4,2,3]")]
    [TestCase("[1,2,3,4,5]", "[1,2,3,4,5]")]
    [TestCase("[10,1,1,6]", "[9,0,1,6]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.FinalPrices(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
