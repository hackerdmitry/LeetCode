using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._714._Best_Time_to_Buy_and_Sell_Stock_with_Transaction_Fee;

[TestFixture(TestName = "714. Best Time to Buy and Sell Stock with Transaction Fee")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,3,2,8,4,9]", 2, 8)]
    [TestCase("[1,3,7,5,10,3]", 3, 6)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxProfit(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
