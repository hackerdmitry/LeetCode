using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._260._Single_Number_III;

[TestFixture(TestName = "260. Single Number III")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,1,3,2,5]", "[3,5]")]
    [TestCase("[-1,0]", "[-1,0]")]
    [TestCase("[0,1]", "[1,0]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.SingleNumber(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
