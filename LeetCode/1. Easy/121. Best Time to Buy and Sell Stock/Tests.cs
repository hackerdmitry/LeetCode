using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._121._Best_Time_to_Buy_and_Sell_Stock;

[TestFixture(TestName = "121. Best Time to Buy and Sell Stock")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[7,1,5,3,6,4]", 5)]
    [TestCase("[7,6,4,3,1]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxProfit(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
