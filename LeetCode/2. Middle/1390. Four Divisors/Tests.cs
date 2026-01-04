using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1390._Four_Divisors;

[TestFixture(TestName = "1390. Four Divisors")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[21,4,7]", 32)]
    [TestCase("[1,2,3,4,5,6,7,8,9,10]", 45)]
    [TestCase("[21,21]", 64)]
    [TestCase("[1,2,3,4,5]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SumFourDivisors(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
