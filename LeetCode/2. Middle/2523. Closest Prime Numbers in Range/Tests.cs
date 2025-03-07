using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2523._Closest_Prime_Numbers_in_Range;

[TestFixture(TestName = "2523. Closest Prime Numbers in Range")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(19, 31, "[29,31]")]
    [TestCase(10, 19, "[11,13]")]
    [TestCase(1, 4, "[2,3]")]
    [TestCase(4, 6, "[-1,-1]")]
    public void Test(int input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.ClosestPrimes(input1, input2);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
