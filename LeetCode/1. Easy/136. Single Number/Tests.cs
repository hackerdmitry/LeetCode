using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._136._Single_Number;

[TestFixture(TestName = "136. Single Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,2,1]", 1)]
    [TestCase("[4,1,2,1,2]", 4)]
    [TestCase("[1]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SingleNumber(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
