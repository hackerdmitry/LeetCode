using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2558._Take_Gifts_From_the_Richest_Pile;

[TestFixture(TestName = "2558. Take Gifts From the Richest Pile")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[25,64,9,4,100]", 4, 29)]
    [TestCase("[1,1,1,1]", 4, 4)]
    public void Test(string input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.PickGifts(input1.ParseIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
