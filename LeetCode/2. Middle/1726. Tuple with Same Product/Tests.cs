using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1726._Tuple_with_Same_Product;

[TestFixture(TestName = "1726. Tuple with Same Product")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,4,6]", 8)]
    [TestCase("[1,2,4,5,10]", 16)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.TupleSameProduct(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}