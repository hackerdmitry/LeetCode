using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._122._Best_Time_to_Buy_and_Sell_Stock_II;

[TestFixture(TestName = "122. Best Time to Buy and Sell Stock II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[7,1,5,3,6,4]", 7)]
    [TestCase("[1,2,3,4,5]", 4)]
    [TestCase("[7,6,4,3,1]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxProfit(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
