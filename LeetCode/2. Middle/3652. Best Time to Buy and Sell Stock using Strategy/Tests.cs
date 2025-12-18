using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3652._Best_Time_to_Buy_and_Sell_Stock_using_Strategy;

[TestFixture(TestName = "3652. Best Time to Buy and Sell Stock using Strategy")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,7,13]", "[-1,-1,0]", 2, 9)]
    [TestCase("[4,2,8]", "[-1,0,1]", 2, 10)]
    [TestCase("[5,4,3]", "[1,1,0]", 2, 9)]
    public void Test(string input1, string input2, int input3, long output)
    {
        var solution = new Solution();
        var actual = solution.MaxProfit(input1.ParseIntArray(), input2.ParseIntArray(), input3);
        Assert.AreEqual(output, actual);
    }
}
