using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._238._Product_of_Array_Except_Self;

[TestFixture(TestName = "238. Product of Array Except Self")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[-1,1,0,-3,3]", "[0,0,9,0,0]")]
    [TestCase("[1,2,3,4]", "[24,12,8,6]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ProductExceptSelf(input.ParseIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
