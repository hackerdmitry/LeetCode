using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1442._Count_Triplets_That_Can_Form_Two_Arrays_of_Equal_XOR;

[TestFixture(TestName = "1442. Count Triplets That Can Form Two Arrays of Equal XOR")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,1,6,7]", 4)]
    [TestCase("[1,1,1,1,1]", 10)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountTriplets(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}