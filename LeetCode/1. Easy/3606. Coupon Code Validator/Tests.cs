using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3606._Coupon_Code_Validator;

[TestFixture(TestName = "3606. Coupon Code Validator")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"SAVE20\",\"\",\"PHARMA5\",\"SAVE@20\"]", "[\"restaurant\",\"grocery\",\"pharmacy\",\"restaurant\"]", "[true,true,true,true]", "[\"PHARMA5\",\"SAVE20\"]")]
    [TestCase("[\"GROCERY15\",\"ELECTRONICS_50\",\"DISCOUNT10\"]", "[\"grocery\",\"electronics\",\"invalid\"]", "[false,true,true]", "[\"ELECTRONICS_50\"]")]
    [TestCase("[\"MI\",\"b_\"]", "[\"pharmacy\",\"pharmacy\"]", "[true,true]", "[\"MI\",\"b_\"]")]
    public void Test(string input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.ValidateCoupons(input1.ParseStringArray(), input2.ParseStringArray(), input3.ParseBoolArray());
        var expected = output.ParseStringArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}