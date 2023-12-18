using NUnit.Framework;

namespace LeetCode._1._Easy._1913._Maximum_Product_Difference_Between_Two_Pairs;

[TestFixture(TestName = "1913. Maximum Product Difference Between Two Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{5,6,2,7,4}, 34)]
    [TestCase(new[]{4,2,5,9,7,4,8}, 64)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxProductDifference(input);
        Assert.AreEqual(output, actual);
    }
}
