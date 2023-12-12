using NUnit.Framework;

namespace LeetCode._1._Easy._1464._Maximum_Product_of_Two_Elements_in_an_Array;

[TestFixture(TestName = "1464. Maximum Product of Two Elements in an Array")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{3,4,5,2}, 12)]
    [TestCase(new[]{3,5,5,2}, 16)]
    [TestCase(new[]{1,5,4,5}, 16)]
    [TestCase(new[]{3,7}, 12)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxProduct(input);
        Assert.AreEqual(output, actual);
    }
}
