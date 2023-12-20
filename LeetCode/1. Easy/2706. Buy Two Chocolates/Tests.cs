using NUnit.Framework;

namespace LeetCode._1._Easy._2706._Buy_Two_Chocolates;

[TestFixture(TestName = "2706. Buy Two Chocolates")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,2,2}, 3, 0)]
    [TestCase(new[]{3,2,3}, 3, 3)]
    public void Test(int[] input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.BuyChoco(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
