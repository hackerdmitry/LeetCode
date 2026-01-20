using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3314._Construct_the_Minimum_Bitwise_Array_I;

[TestFixture(TestName = "3314. Construct the Minimum Bitwise Array I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,3,5,7]", "[-1,1,4,3]")]
    [TestCase("[11,13,31]", "[9,12,15]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.MinBitwiseArray(input.ParseIntArray());
        var expected = output.ParseIntArray();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
